using Krypton.Toolkit;
using Sqlite.Db.Model;
using Sqlite.Db;
using System;
using System.Windows.Forms;
using System.Linq;
using WaMarketProApp.Utils;

namespace WaMarketProApp
{
    public partial class FrmReplyMsgAdd : KryptonForm
    {
        private Repository<ReplyButtonModel> btnService = new Repository<ReplyButtonModel>();
        private Repository<ReplyMessageModel> msgService = new Repository<ReplyMessageModel>();
        public bool IsAdd { get; set; }
        public int MsgId { get; set; }

       
        public FrmReplyMsgAdd()
        {
            InitializeComponent();
            this.BindCondition();
           

        }
        private void BindCondition()
        {
            this.comCondition.Items.Clear();
            var list = Enum.GetNames(typeof(ReplyType)).ToList();
            foreach (var item in list)
            {
                this.comCondition.Items.Add(item);
            }
            this.comCondition.SelectedIndex = 0;
        }

 
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "File|*.jpg;*.jpeg;*.png;*.jpeg;*.gif;*.doc;*docx;*.pdf;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var file = open.FileName;
                this.txtFile.Text=file;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFile.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTitle.Text))
            {
                KryptonMessageBox.Show("please enter user input!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);
                return;
            }
            if (string.IsNullOrEmpty(this.txtContent.Text))
            {
                KryptonMessageBox.Show("please enter user reply content!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);
                return;
            }
            var condition= (ReplyType)Enum.Parse(typeof(ReplyType), this.comCondition.Text);
            
            var model = new ReplyMessageModel
            {
                UserInput = this.txtTitle.Text,
                Content = this.txtContent.Text,
                File = this.txtFile.Text,
                Condition = condition,

            };
            if (this.IsAdd)
            {
                var r = this.msgService.Insert(model);
            }
            else
            {
                model.Id = MsgId;
                this.msgService.Update(model);

            }

            KryptonMessageBox.Show("Save Success!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);
            this.DialogResult = DialogResult.OK;
        }

 
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmMsgAdd_Load(object sender, EventArgs e)
        {
            SetLang();
            if (!this.IsAdd)
            {
               var msg=  msgService.GetById(MsgId);
                this.txtTitle.Text = msg.UserInput;
                this.txtContent.Text = msg.Content;
                this.txtFile.Text = msg.File;
                this.comCondition.Text = Enum.GetName(typeof(ReplyType), msg.Condition);

            }
        }

        private void SetLang()
        {
            var model = LangUtils.GetLang();
            if (model != null)
            {
                this.Text = model.FrmReplyMsgAdd;
                kryptonLabel1.Text = model.LabUserInput;
                kryptonLabel2.Text = model.LabUserCondition;
                kryptonLabel4.Text = model.LabAttachment;
                kryptonLabel5.Text = model.LabUserReplyContent;
                btnClear.Text = model.BtnClear;
                btnSave.Text = model.BtnSave;
                btnOk.Text = model.BtnCancel;
                btnBrowse.Text = model.BtnBrowse;
            }
        }
    }
}
