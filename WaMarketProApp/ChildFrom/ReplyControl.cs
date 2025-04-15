using Krypton.Toolkit;
using Sqlite.Db.Model;
using Sqlite.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wa.Api;
using WaMarketProApp.Extensions;
using Wa.Model;
using WaMarketProApp.Utils;

namespace WaMarketProApp.ChildFrom
{
    public partial class ReplyControl : UserControl
    {
        private Repository<ReplyMessageModel> msgService = new Repository<ReplyMessageModel>();
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();
        public override string Text { get; set; } = "AutoReply";
        public WaApi WaApi { get; set; }
        public ReplyControl()
        {
            this.Text = LangUtils.GetLang()?.MenuWaAuto;
            InitializeComponent();
        }



        private async void btnStart_Click(object sender, EventArgs e)
        {
            var msgList = msgService.GetList();
            if (msgList.Count == 0)
            {
                KryptonMessageBox.Show("Please add your message!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, showCtrlCopy: false);
                return;
            }
        
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            var token = this.cancellationToken.Token;

            var btnList=new List<ReplyButtonModel>();
            this.AddResult("Start---------------");
            await Task.Factory.StartNew(async () =>
            {
                await this.AutoReply(msgList, btnList, token).ContinueWith(t =>
                {
                    this.cancellationToken = new CancellationTokenSource();
                    this.InvokeOnUiThreadIfRequired(() =>
                    {
                        this.btnStart.Enabled = true;
                        this.btnStop.Enabled = false;
                        this.AddResult("Stop---------------");
                    });
                });
            }, token);
        }

        private async Task AutoReply(List<ReplyMessageModel> msgList, List<ReplyButtonModel> btnList, CancellationToken cancellation)
        {

            this.WaApi.MarkAllRead(100);
            while (true)
            {
                if (cancellation.IsCancellationRequested)
                {
                    break;
                }
                var unReadList = this.WaApi.GetUnreadMessageList();
                foreach (var item in unReadList)
                {
                    var unReadStr = $"Received message[{item.Content}] from User[{item.FromId.TrimEnd("@c.us".ToCharArray())}] -- {DateTime.Now.ToString()}";
                    this.AddResult(unReadStr);
                    await Task.Delay(1000);
                    this.WaApi.MarkRead(item.FromId);
                    await Task.Delay(2000);
                    ReplyMessageModel replyMsg = new ReplyMessageModel();
                    if (item.Type != "chat")
                    {
                        replyMsg = GetReplyAnyMsg(msgList);
                    }
                    else
                    {
                        replyMsg = GetReplyMsg(msgList, item.Content);
                    }
                    if (replyMsg != null)
                    {
                        var replyBtnList = btnList.Where(t => t.ReplyId == replyMsg.Id).Select(b => new Buttons { Text = b.Title, Url = b.Content, Type = b.Type }).ToList();
                        var c = this.WaApi.SendMessage(item.FromId, replyMsg.Content, string.Empty, replyMsg.File, replyBtnList);
                        var replyStr=string.Empty;
                        if (c.Item1)
                        {
                             replyStr = $"Reply message[{replyMsg.Content}] To User[{item.FromId.TrimEnd("@c.us".ToCharArray())}] -- {DateTime.Now.ToString()}";
                        }
                        else
                        {
                            replyStr = $"Reply Fail--[{c.Item2}] To User[{item.FromId.TrimEnd("@c.us".ToCharArray())}] -- {DateTime.Now.ToString()}";
                        }
                        this.AddResult(replyStr);
                        await Task.Delay(2000);
                    }
                    else
                    {
                        var replyStr = $"[No matching reply messages were found!] -- {DateTime.Now.ToString()}";
                        this.AddResult(replyStr);
                    }
                }
                await Task.Delay(5000);
            }

        }



        private ReplyMessageModel GetReplyAnyMsg(List<ReplyMessageModel> msgList)
        {
            return msgList.FirstOrDefault(m => m.Condition == ReplyType.Any);
        }

        private ReplyMessageModel GetReplyMsg(List<ReplyMessageModel> msgList, string receiveMsg)
        {

            var replyTypeList = Enum.GetValues(typeof(ReplyType)).Cast<ReplyType>().ToList();
            replyTypeList.Sort();
            foreach (var msgType in replyTypeList)
            {
                var mList = msgList.Where(m => m.Condition == msgType);
                if (mList.Any())
                {
                    var func = GetMsgFunc(msgType, receiveMsg);
                    var msg = mList.FirstOrDefault(func);
                    if (msg != null)
                    {
                        return msg;
                    }
                   
                }
            }
            return null;

        }

        private Func<ReplyMessageModel, bool> GetMsgFunc(ReplyType type, string receiveMsg)
        {
            Func<ReplyMessageModel, bool> msgFunc;
            switch (type)
            {
                case ReplyType.Exact:
                    msgFunc = msg => msg.UserInput.ToUpper() == receiveMsg.ToUpper();
                    break;
                case ReplyType.StartWith:
                    msgFunc = msg => receiveMsg.StartsWith(msg.UserInput,StringComparison.OrdinalIgnoreCase);
                    break;
                case ReplyType.EndWith:
                    msgFunc = msg => receiveMsg.EndsWith(msg.UserInput, StringComparison.OrdinalIgnoreCase);
                    break;
                case ReplyType.Contains:
                    msgFunc = msg => receiveMsg.IndexOf(msg.UserInput, StringComparison.OrdinalIgnoreCase)>=0;
                    break;
                case ReplyType.Any:
                    msgFunc = msg => true;
                    break;
                default:
                    msgFunc = msg => false;
                    break;
            }
            return msgFunc;
        }

        private void AddResult(string msg)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                this.txtLogs.AppendText(msg);
                this.txtLogs.AppendText(Environment.NewLine);

            });
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            this.cancellationToken.Cancel();
        
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtLogs.Clear();
        }

        private void ReplyControl_Load(object sender, EventArgs e)
        {
            var model = LangUtils.GetLang();
            if (model != null)
            {
                this.Text = model.MenuWaAuto;
                
                btnStart.Text = model.BtnStart;
                btnStop.Text = model.BtnStop;
                btnClear.Text = model.BtnClear;
                
            }
        }
    }
}
