using Krypton.Navigator;
using Krypton.Toolkit;
using Sqlite.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wa.Api;
using WaMarketProApp.ChildFrom;
using WaMarketProApp.Extensions;
using WaMarketProApp.Model;
using WaMarketProApp.Utils;

namespace WaMarketProApp
{
    public partial class FrmMain : KryptonForm
    {
        private Repository<Sqlite.Db.Model.LangModel> service = new Repository<Sqlite.Db.Model.LangModel>();
        private WaApi waApi = new WaApi("WaMarketPro");
        public FrmMain()
        {
            InitializeComponent();


        }
        private void BindLang()
        {
            var list = new List<Language> {
                 new Language { Name = "English", Code = "en" },
                 new Language { Name = "العربية", Code = "ar" },
                 new Language { Name = "azərbaycan", Code = "az" },
                 new Language { Name = "bosanski", Code = "bs" },
                new Language { Name = "Italiano", Code = "it" },
                 new Language { Name = "Dansk", Code = "da" },
                 new Language { Name = "Deutsch (Deutschland)", Code = "de" },
                 new Language { Name = "Français", Code = "fr" },
                 new Language { Name = "Português", Code = "pt" },
                 new Language { Name = "Español", Code = "es" },
                  new Language { Name = "euskara", Code = "eu" },
                 new Language { Name = "Bahasa Indonesia", Code = "id" },
                 new Language { Name = "Bahasa Melayu", Code = "ms" },
                 new Language { Name = "Filipino", Code = "fil" },
                 new Language { Name = "latviešu", Code = "lv" },
                 new Language { Name = "lietuvių", Code = "lt" },
                  new Language { Name = "magyar", Code = "hu" },
                  new Language { Name = "Nederlands", Code = "nl" },
                    new Language { Name = "norsk", Code = "no" },
                     new Language { Name = "oʻzbekcha", Code = "uz" },
                 new Language { Name = "Tiếng Việt", Code = "vi" },
                 new Language { Name = "Türkçe", Code = "tr" },
                 new Language { Name = "हिन्दी", Code = "hi" },
                 new Language { Name = "ខ្មែរ", Code = "km" },
                 new Language { Name = "简体中文", Code = "zh-CN" },
                 new Language { Name = "繁體中文", Code = "zh-TW" }

            };

            this.krgComLang.SelectedIndexChanged -= krgComLang_SelectedIndexChanged;
            this.krgComLang.DataSource = list;
            this.krgComLang.DisplayMember = "Name";
            this.krgComLang.ValueMember = "Code";
            this.krgComLang.SelectedIndexChanged += krgComLang_SelectedIndexChanged;

        }



        private void CreatePage(Control control)
        {
            var page = new KryptonPage
            {
                Text = control.Text,
                TextTitle = control.Text
            };
            control.Dock = DockStyle.Fill;
            page.Controls.Add(control);

            var bsa = new ButtonSpecAny
            {
                Tag = page,
                Style = PaletteButtonStyle.FormClose,
                Type = PaletteButtonSpecStyle.Close,
            };
            bsa.Click += new EventHandler(OnClosePage);
            page.ButtonSpecs.Add(bsa);

            var cell = this.kryptonNavigator1;
            if (cell.Pages.All(p => p.Text != page.Text))
            {
                cell.Pages.Add(page);
                cell.SelectedPage = page;
            }
            else
            {
                var page1 = cell.Pages.FirstOrDefault(p => p.Text == page.Text);
                cell.SelectedPage = page1;

            }

        }

        private void OnClosePage(object sender, EventArgs e)
        {
            var bsa = (ButtonSpecAny)sender;
            var page = (KryptonPage)bsa.Tag;
            if (page != null)
            {
                this.kryptonNavigator1.Pages.Remove(page);
            }
        }

        private void krgbBtnLogin_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => this.Login());
        }

        private void Login()
        {
            try
            {
                this.waApi.Start();
                this.GetMe();
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("Chrome failed to start: exited normally"))
                {
                    KryptonMessageBox.Show("You have opened multiple Chorme, please close it and try again!", @"Error", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                }
                else
                {
                    KryptonMessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                }
            }
        }

        private void GetMe()
        {
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    await Task.Delay(2000);
                    var r = this.waApi.ExLogin();
                    if (r)
                    {
                        var phone = this.waApi.GetMe();
                        this.InvokeOnUiThreadIfRequired(() =>
                        {
                            this.tsslabStatus.Text = "Logined";
                            this.tsslabStatus.ForeColor = Color.Green;
                            this.tsslabPhone.Text = phone;
                        });
                        break;
                    }
                }
            });
        }

        private void krgbBtnMessage_Click(object sender, EventArgs e)
        {
            CreatePage(new MessageControl());
        }

        private void krgbBtnFilter_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }

            CreatePage(new FilterControl() { WaApi = this.waApi });
        }

        private void krgbBtnJoin_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            CreatePage(new JoinGroupControl() { WaApi = this.waApi });
        }

        private void krgbBtnGroupSend_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            CreatePage(new GroupSendControl() { WaApi = this.waApi });
        }

        private void krgbBtnReplyMsg_Click(object sender, EventArgs e)
        {

            CreatePage(new ReplyMessageControl());
        }

        private void krgbBtnReply_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            CreatePage(new ReplyControl() { WaApi = this.waApi });
        }

        private void krgbBtnContactSend_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            CreatePage(new ContactSendControl() { WaApi = this.waApi });
        }

        private void krgbBtnPhoneSend_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            CreatePage(new PhoneSendControl() { WaApi = this.waApi });
        }

        private void krgbBtnExtract_Click(object sender, EventArgs e)
        {
            if (!this.waApi.ExLogin())
            {
                KryptonMessageBox.Show("Please Login your Whatsapp!", "Info", MessageBoxButtons.OK, KryptonMessageBoxIcon.Error, showCtrlCopy: false);
                return;
            }
            CreatePage(new GroupExtractControl() { WaApi = this.waApi });
        }

        private void krgbBtnTele_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/item/telegram-marketer-tools-6/33837496");
        }

        private void Navigation(string url)
        {
            var psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void krgbBtnTgInvite_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/item/tgsender-contactgroup-sender/37945922");
        }

        private void krgbBtnTgNear_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/item/telegram-bulk-senderextractscraperinvite-market-pro/41673729");
        }

        private void krgbBtnScrape_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/item/social-network-data-scraper-pro/34467442");
        }

        private void krgbBtnEmail_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/item/email-bulk-searchextractadd-tools/35506368");
        }

        private void krgbBtnGoogle_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/item/fast-google-emailphone-extract-pro/39945619");
        }

        private void krgbBtnTg_Click(object sender, EventArgs e)
        {
            this.Navigation("https://t.me/IonicSupport");
        }

        private void krgbBtnWa_Click(object sender, EventArgs e)
        {
            this.Navigation("https://api.whatsapp.com/send?phone=13156299582&text=hello");
        }

        private void krgbBtnOnline_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/user/ionicstudio/portfolio");
        }

        private void krgbBtnFollow_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/user/ionicstudio");
        }

        private void krgbBtnWeb_Click(object sender, EventArgs e)
        {
            this.Navigation("https://codecanyon.net/user/ionicstudio/portfolio");
        }

        private void krgbBtnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                try
                {
                    if (KryptonMessageBox.Show("Are you sure exit?", "Info",
                                    MessageBoxButtons.OKCancel, KryptonMessageBoxIcon.Question, showCtrlCopy: false)
                             == DialogResult.OK)
                    {

                        if (this.waApi != null)
                        {
                            this.waApi.Quit();
                        }

                        ShutdownChromeDriver();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                catch (Exception)
                {
                }

            }
        }
        private void ShutdownChromeDriver()
        {
            var processes = Process.GetProcesses().Where(p => p.ProcessName == "chromedriver");
            foreach (var process in processes)
            {
                try
                {
                    process.Kill();
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BindLang();
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            var code = this.service.GetById(1)?.Code;
            LangUtils.LangKey = code;
            LoadLang();

        }


        private void LoadLang()
        {
            var model = LangUtils.GetLang();
            if (model != null)
            {
                this.Text = model.Title;
                kryptonRibbonTab1.Text = model.MenuWa;
                krtSetting.Text = model.MenuSet;
                krtAbout.Text = model.MenuAbout;
                toolStripStatusLabel1.Text = model.MenuStatus;
                toolStripStatusLabel3.Text = model.MenuPhone;
                krgbBtnLogin.TextLine1 = model.MenuWaLogin;
                krgbBtnMessage.TextLine1 = model.MenuWaMsg;
                krgbBtnFilter.TextLine1 = model.MenuWaFilter;
                krgbBtnContactSend.TextLine1 = model.MenuWaSend;
                krgbBtnPhoneSend.TextLine1 = model.MenuWaPhone;
                krgbBtnJoin.TextLine1 = model.MenuWaJoin;
                krgbBtnExtract.TextLine1 = model.MenuWaExtract;
                krgbBtnGroupSend.TextLine1 = model.MenuWaSend;
                krgbBtnReplyMsg.TextLine1 = model.MenuWaReply;
                krgbBtnReply.TextLine1 = model.MenuWaAuto;
                krgbBtnWa.TextLine1 = model.MenuHelpWa;
                krgbBtnFollow.TextLine1 = model.MenuHelpFollow;
                krgbBtnAbout.TextLine1 = model.MenuHelpAbout;

                krbMessage.TextLine1 = model.GroupBoxMsg;
                krgContact.TextLine1 = model.GroupBoxContact;
                kryptonRibbonGroup1.TextLine1 = model.GroupBoxGroup;
                krbReply.TextLine1 = model.GroupReply;
                krgLang.TextLine1 = model.MenuGroupLang;
                krgAbout.TextLine1 = model.MenuAbout;
            }
        }

        private void krgComLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.krgComLang.SelectedIndex > -1)
            {
                var lang = this.krgComLang.SelectedItem as Language;
                if (!string.IsNullOrEmpty(lang.Code))
                {
                    LangUtils.LangKey = lang.Code;
                    LoadLang();

                    var model = this.service.GetById(1);
                    model.Name = lang.Name;
                    model.Code = lang.Code;
                    this.service.Update(model);
                }
            }

        }
    }
}
