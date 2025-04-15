using Krypton.Toolkit;
using Sqlite.Db;
using Sqlite.Db.Model;
using System;
using System.Windows.Forms;
using WaMarketProApp.Utils;

namespace WaMarketProApp.ChildFrom
{
    public partial class MessageControl : UserControl
    {
        private Repository<MessageModel> msgService = new Repository<MessageModel>();
        public override string Text { get; set; } = "Message";
        public MessageControl()
        {
            this.Text = LangUtils.GetLang()?.MenuGroupMsg;
            InitializeComponent();
        }
        private void BindMgList()
        {
            var list = this.msgService.GetList();
            this.dgvMsg.DataSource = list;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmMsgAdd() { MsgId = 0, IsAdd = true };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BindMgList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvMsg.Rows.Count == 0)
            {
                KryptonMessageBox.Show("No Data!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                return;
            }
            var msgId = Convert.ToInt32(this.dgvMsg.CurrentRow.Cells["Column6"].Value);
            var frm = new FrmMsgAdd() { MsgId = msgId, IsAdd = false };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BindMgList();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvMsg.Rows.Count == 0)
            {
                KryptonMessageBox.Show("No Data!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                return;
            }
            if (DialogResult.Yes == KryptonMessageBox.Show("Are you sure Del?", "Info", MessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question, showCtrlCopy: false))
            {
                var msgId = Convert.ToInt32(this.dgvMsg.CurrentRow.Cells[0].Value);
                var r = this.msgService.DeleteById(msgId);
                this.BindMgList();
                var msg = r  ? "Del  Success!" : "Del Fail!";
                KryptonMessageBox.Show(msg, "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Information, showCtrlCopy: false);
            }
        }



        private void MessageControl_Load(object sender, EventArgs e)
        {
            this.BindMgList();
            SetLang();
        }
        private void SetLang()
        {
            var model = LangUtils.GetLang();
            if (model != null)
            {
                this.Text = model.MenuGroupMsg;

                dgvMsg.Columns["Column1"].HeaderText = model.ColType;
                dgvMsg.Columns["Column2"].HeaderText = model.ColEnable;
                dgvMsg.Columns["Column3"].HeaderText = model.ColTitle;
                dgvMsg.Columns["Column4"].HeaderText = model.ColFile;
                dgvMsg.Columns["Column5"].HeaderText = model.ColContent;
                btnAdd.Text = model.BtnAdd;
                btnEdit.Text = model.BtnEdit;
                btnDel.Text = model.BtnDel;


            }
        }
    }
}
