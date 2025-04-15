using Krypton.Toolkit;
using Sqlite.Db;
using Sqlite.Db.Model;
using System;
using System.Windows.Forms;
using WaMarketProApp.Utils;

namespace WaMarketProApp
{
    public partial class FrmMsgAdd : KryptonForm
    {
        private Repository<MessageModel> msgService = new Repository<MessageModel>();
        public bool IsAdd { get; set; }
        public int MsgId { get; set; }
        public FrmMsgAdd()
        {
            InitializeComponent();
           
        }

        private void FrmMsgAdd_Load(object sender, EventArgs e)
        {
            SetLang();
            if (!this.IsAdd)
            {
                var msg = msgService.GetById(MsgId);
                this.txtTitle.Text = msg.Title;
                this.txtContent.Text = msg.Content;
                this.txtFile.Text = msg.File;
                if (msg.Type == "Group")
                {
                    this.rbContact.Checked = false;
                    this.rbGroup.Checked = true;
                }
                else
                {
                    this.rbContact.Checked = true;
                    this.rbGroup.Checked = false;
                }

            }
        }

        private void SetLang()
        {
            var model = LangUtils.GetLang();
            if (model != null)
            {
                this.Text = model.FrmMsgAdd;
                kryptonLabel1.Text = model.LabTitle;
                kryptonLabel2.Text = model.LabType;
                kryptonLabel3.Text = model.LabEnable;
                kryptonLabel4.Text = model.LabAttachment;
                kryptonLabel5.Text = model.LabContent;
                btnClear.Text = model.BtnClear;
                btnSave.Text = model.BtnSave;
                btnOk.Text = model.BtnCancel;
                btnBrowse.Text = model.BtnBrowse;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "File|*.jpg;*.jpeg;*.png;*.doc;*docx;*.pdf;*.mp4;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var file = open.FileName;
                this.txtFile.Text = file;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFile.Clear();
        }

        private void rbContact_CheckedChanged(object sender, EventArgs e)
        {
            this.rbGroup.Checked = !rbContact.Checked;
        }

        private void rbGroup_CheckedChanged(object sender, EventArgs e)
        {
            rbContact.Checked = !this.rbGroup.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTitle.Text))
            {
                KryptonMessageBox.Show("please enter title!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);
                return;
            }
            if (string.IsNullOrEmpty(this.txtContent.Text))
            {
                KryptonMessageBox.Show("please enter content!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);
                return;
            }
            var type = "Contact";
            if (rbContact.Checked)
            {
                type = "Contact";
            }
            if (rbGroup.Checked)
            {
                type = "Group";
            }

            var model = new MessageModel
            {
                Title = this.txtTitle.Text,
                Content = this.txtContent.Text,
                File = this.txtFile.Text,
                Enable = this.cbEnable.Checked,
                Type = type,

            };
            if (this.IsAdd)
            {
                this.msgService.Insert(model);
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
    }
}
