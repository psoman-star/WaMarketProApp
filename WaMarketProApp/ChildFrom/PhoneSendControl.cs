using Krypton.Toolkit;
using Sqlite.Db.Model;
using Sqlite.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wa.Api;
using WaMarketProApp.Extensions;
using WaMarketProApp.Model;
using Wa.Model;
using WaMarketProApp.Utils;

namespace WaMarketProApp.ChildFrom
{
    public partial class PhoneSendControl : UserControl
    {
        private Random random = new Random();
        private Repository<ButtonModel> btnService = new Repository<ButtonModel>();
        private Repository<Sqlite.Db.Model.MessageModel> msgService = new Repository<Sqlite.Db.Model.MessageModel>();
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();
        private List<FilterResultModel> list = new List<FilterResultModel>();
        private int fail = 0;
        private int success = 0;
        public override string Text { get; set; } = "PhoneSend";
        public WaApi WaApi { get; set; }
        public PhoneSendControl()
        {
            this.Text = LangUtils.GetLang()?.MenuWaPhone;
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            var open = new OpenFileDialog();
            open.Filter = " File|*.csv;*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var path = open.FileName;
                try
                {
                    var list = Path.GetExtension(path) == ".txt" ? this.ImportTxt(path) : this.ImportCsv(path);
                    AddListItem(list);
                    this.labTotal.Text = list.Count.ToString();

                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);

                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.labTotal.Text = "0";
        }
        private void AddListItem(List<ImportItem> list)
        {
            if (list.Count > 0)
            {
                this.listView1.Items.Clear();
                var itemList = list.Select(a => new ListViewItem(new[] { a.Phone, a.Name }));
                this.listView1.Items.AddRange(itemList.ToArray());
            }

        }

        private List<ImportItem> ImportTxt(string path)
        {
            return File.ReadAllLines(path)
                   .Select(s => Regex.Replace(s, @"[^0-9]+", ""))
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Select(a => new ImportItem { Phone = a, Name = string.Empty })
                    .ToList();


        }
        private List<ImportItem> ImportCsv(string path)
        {
            var resultList = new List<ImportItem>();
            var strs = File.ReadAllLines(path, Encoding.UTF8).Skip(1).ToList();
            if (strs.Count() > 0)
            {
                foreach (var item in strs)
                {
                    var arr = item.Split(',');
                    var model = new ImportItem
                    {
                        Phone = Regex.Replace(arr[0], @"[^0-9]+", ""),
                        Name = arr[1]
                    };
                    resultList.Add(model);
                }
            }
            return resultList;
        }

        private List<ImportItem> GetImportList()
        {
            var list = new List<ImportItem>();
            if (this.listView1.Items.Count == 0)
            {
                return list;
            }
            foreach (ListViewItem item in this.listView1.Items)
            {
                var model = new ImportItem
                {
                    Phone = item.SubItems[0].Text,
                    Name = item.SubItems[1].Text
                };
                list.Add(model);
            }
            return list;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

            if (this.listView1.Items.Count == 0)
            {
                KryptonMessageBox.Show("Please import your phone number!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                return;
            }
            var msgList = msgService.GetList(m => m.Enable && m.Type == "Contact");
            if (msgList.Count == 0)
            {
                KryptonMessageBox.Show("Please add your message!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                return;
            }

            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            var pList = GetImportList();
            var token = this.cancellationToken.Token;
            Action<bool, string, string> acResult = (r, phone, reason) => this.AddSendResult(r, phone, reason, this.dgvList);
            await Task.Factory.StartNew(async () =>
            {
                await this.BulkSend(pList, msgList, acResult, token).ContinueWith(t =>
                {
                    this.cancellationToken = new CancellationTokenSource();
                    this.InvokeOnUiThreadIfRequired(() =>
                    {
                        this.btnStart.Enabled = true;
                        this.btnStop.Enabled = false;
                    });
                });
            }, token);
        }

        private async Task BulkSend(List<ImportItem> phoneList, List<Sqlite.Db.Model.MessageModel> msgList, Action<bool, string, string> actionResult, CancellationToken cancellation)
        {
            var sendMsgMin = (int)this.nudSendMsgMin.Value;
            var sendMsgMax = (int)this.nudSendMsgMax.Value;
            var sendMsgNum = (int)this.nudSendMsgNum.Value;
            var sendDelayMin = (int)this.nudSendDelayMin.Value;
            var sendDelayMax = (int)this.nudSendDelayMax.Value;


            var btnMsgList = btnService.GetList();
            var nums = 0;
            foreach (var pItem in phoneList)
            {
                if (cancellation.IsCancellationRequested)
                {
                    break;
                }
                nums++;
                var phone = pItem.Phone + "@c.us";
                var index = this.random.Next(0, msgList.Count);
                var msgModel = msgList[index];
                var msgContent = msgModel.Content;
                if (!string.IsNullOrEmpty(pItem.Name))
                {
                    msgContent = msgModel.Content;
                }
                else
                {
                    msgContent = msgModel.Content.Replace("{UserName}", pItem.Name);
                }

                var btnMlist = this.btnService.GetList(m => m.MsgId == msgModel.Id).Select(b => new Buttons { Text = b.Title, Url = b.Content, Type = b.Type }).ToList();
                var c = this.WaApi.SendMessage(phone, msgModel.Content, msgModel.Title, msgModel.File, btnMlist);
                actionResult(c.Item1, phone, c.Item2);
                var delay = this.random.Next(sendDelayMin, sendDelayMax) * 1000;
                await Task.Delay(delay);
                if (nums % sendMsgNum == 0)
                {
                    var delay1 = this.random.Next(sendMsgMin, sendMsgMax) * 1000;
                    await Task.Delay(delay1);
                }
            }


        }

        private void AddSendResult(bool status, string phone, string reason, KryptonDataGridView dgv)
        {
            var ph = phone.TrimEnd("@c.us".ToCharArray());
            var s = status ? "Success" : "Fail";
            this.InvokeOnUiThreadIfRequired(() =>
            {
                dgv.Rows.Add(new object[] { ph, s, reason });
                if (status)
                {
                    this.success++;
                    this.labExist.Text = this.success.ToString();
                }
                else
                {
                    this.fail++;
                    this.labNoExist.Text = this.fail.ToString();
                }

            });
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            this.cancellationToken.Cancel();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvList.Rows.Count == 0)
                {
                    KryptonMessageBox.Show("No Data!", @"Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                    return;
                }

                var resultList = list.Select(g => g.PhoneNumber).ToArray();
                var dialog = new SaveFileDialog
                {
                    Filter = @"Text File|*.txt",
                    FileName = $"Exist-PhoneList-{DateTime.Now.ToString("yyyy-MM-ddHHmmss")}"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.FileName;
                    File.WriteAllLines(path, resultList, Encoding.UTF8);
                    KryptonMessageBox.Show("Save Success!", @"Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);

                }
            }
            catch (Exception ex)
            {

                KryptonMessageBox.Show(ex.Message, @"Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
            }
        }

        private void btnClearR_Click(object sender, EventArgs e)
        {
            this.dgvList.Rows.Clear();
            this.list.Clear();
            this.fail = 0;
            this.success = 0;
            this.labExist.Text = "0";
            this.labNoExist.Text = "0";
        }

        private void PhoneSendControl_Load(object sender, EventArgs e)
        {
            SetLang();
        }
        private void SetLang()
        {
            var model = LangUtils.GetLang();
            if (model != null)
            {
                this.Text = model.MenuWaPhone;
                kryptonGroupBox1.Values.Heading = model.GroupPhoneNumber;
                kryptonLabel1.Text = model.LabTotal;
                kryptonLabel2.Text = model.LabSucces;
                kryptonLabel3.Text = model.LabFail;
                btnImport.Text = model.BtnImport;
                btnClear.Text = model.BtnClear;
                btnStart.Text = model.BtnStart;
                btnStop.Text = model.BtnStop;
                btnClearR.Text = model.BtnClear;
                kryptonLabel4.Text = model.LabWait;
                kryptonLabel5.Text = model.LabWait;
                kryptonLabel8.Text = model.LabMessage;
                kryptonLabel7.Text = model.LabSeconds;
                kryptonLabel10.Text = model.LabSeconds1;

                dgvList.Columns["Column1"].HeaderText = model.ColPhoneNumber;
                dgvList.Columns["Column2"].HeaderText = model.ColStatus;
                dgvList.Columns["Column3"].HeaderText = model.ColReason;
            }
        }
    }
}
