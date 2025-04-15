using Krypton.Toolkit;
using Sqlite.Db;
using Sqlite.Db.Model;
using System;
using System.Windows.Forms;
using WaMarketProApp.Utils;

namespace WaMarketProApp.ChildFrom
{
    public partial class ReplyMessageControl : UserControl
    {
        private Repository<ReplyMessageModel> msgService = new Repository<ReplyMessageModel>();
        public override string Text { get; set; } = "Reply Msg";
        public ReplyMessageControl()
        {
            this.Text = LangUtils.GetLang()?.MenuWaReply;
            InitializeComponent();
        }
        private void BindMgList()
        {
            var list = this.msgService.GetList();
            this.dgvMsg.DataSource = list;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmReplyMsgAdd() { MsgId = 0, IsAdd = true };
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
            var frm = new FrmReplyMsgAdd() { MsgId = msgId, IsAdd = false };
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
                var msg = r ? "Del  Success!" : "Del Fail!";
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
                this.Text = model.MenuWaReply;

                dgvMsg.Columns["Column7"].HeaderText = model.ColCondition;
                dgvMsg.Columns["Column3"].HeaderText = model.ColUserInput;
                dgvMsg.Columns["Column4"].HeaderText = model.ColFile;
                dgvMsg.Columns["Column5"].HeaderText = model.ColReplyConect;
                btnAdd.Text = model.BtnAdd;
                btnEdit.Text = model.BtnEdit;
                btnDel.Text = model.BtnDel;


            }
        }
    }
}
