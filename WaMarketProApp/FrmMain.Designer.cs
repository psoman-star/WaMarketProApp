namespace WaMarketProApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.krbMessage = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbBtnLogin = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnMessage = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgContact = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbBtnFilter = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnContactSend = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnPhoneSend = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbBtnJoin = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnExtract = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnGroupSend = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krbReply = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbBtnReplyMsg = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnReply = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krtSetting = new Krypton.Ribbon.KryptonRibbonTab();
            this.krgLang = new Krypton.Ribbon.KryptonRibbonGroup();
            this.krgComTriple = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgComLang = new Krypton.Ribbon.KryptonRibbonGroupComboBox();
            this.krtAbout = new Krypton.Ribbon.KryptonRibbonTab();
            this.krgAbout = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple9 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbBtnWa = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnFollow = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbBtnAbout = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabPhone = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowMinimizedChange = false;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.QATLocation = Krypton.Ribbon.QATLocation.Hidden;
            this.kryptonRibbon1.RibbonAppButton.AppButtonVisible = false;
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.krtSetting,
            this.krtAbout});
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1360, 159);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.krbMessage,
            this.krgContact,
            this.kryptonRibbonGroup1,
            this.krbReply});
            this.kryptonRibbonTab1.Text = "Whatsapp";
            // 
            // krbMessage
            // 
            this.krbMessage.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.krbMessage.TextLine1 = "Message";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbBtnLogin,
            this.krgbBtnMessage});
            // 
            // krgbBtnLogin
            // 
            this.krgbBtnLogin.ImageLarge = global::WaMarketProApp.Properties.Resources.login_wa64;
            this.krgbBtnLogin.ImageSmall = global::WaMarketProApp.Properties.Resources.login_wa16;
            this.krgbBtnLogin.TextLine1 = "Login Wa";
            this.krgbBtnLogin.Click += new System.EventHandler(this.krgbBtnLogin_Click);
            // 
            // krgbBtnMessage
            // 
            this.krgbBtnMessage.ImageLarge = global::WaMarketProApp.Properties.Resources.msg_64;
            this.krgbBtnMessage.ImageSmall = global::WaMarketProApp.Properties.Resources.msg_16;
            this.krgbBtnMessage.TextLine1 = "Message";
            this.krgbBtnMessage.Click += new System.EventHandler(this.krgbBtnMessage_Click);
            // 
            // krgContact
            // 
            this.krgContact.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.krgContact.TextLine1 = "Contact";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbBtnFilter,
            this.krgbBtnContactSend,
            this.krgbBtnPhoneSend});
            // 
            // krgbBtnFilter
            // 
            this.krgbBtnFilter.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbBtnFilter.ImageLarge")));
            this.krgbBtnFilter.ImageSmall = global::WaMarketProApp.Properties.Resources.filter_16;
            this.krgbBtnFilter.TextLine1 = "Filter";
            this.krgbBtnFilter.Click += new System.EventHandler(this.krgbBtnFilter_Click);
            // 
            // krgbBtnContactSend
            // 
            this.krgbBtnContactSend.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbBtnContactSend.ImageLarge")));
            this.krgbBtnContactSend.ImageSmall = global::WaMarketProApp.Properties.Resources.contactsend_16;
            this.krgbBtnContactSend.TextLine1 = "Contacts";
            this.krgbBtnContactSend.Click += new System.EventHandler(this.krgbBtnContactSend_Click);
            // 
            // krgbBtnPhoneSend
            // 
            this.krgbBtnPhoneSend.ImageLarge = global::WaMarketProApp.Properties.Resources.phone1_64;
            this.krgbBtnPhoneSend.ImageSmall = global::WaMarketProApp.Properties.Resources.phone1_16;
            this.krgbBtnPhoneSend.TextLine1 = "Phone Send";
            this.krgbBtnPhoneSend.Click += new System.EventHandler(this.krgbBtnPhoneSend_Click);
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3});
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbBtnJoin,
            this.krgbBtnExtract,
            this.krgbBtnGroupSend});
            // 
            // krgbBtnJoin
            // 
            this.krgbBtnJoin.ImageLarge = global::WaMarketProApp.Properties.Resources.join_64;
            this.krgbBtnJoin.ImageSmall = global::WaMarketProApp.Properties.Resources.join_16;
            this.krgbBtnJoin.TextLine1 = "Join";
            this.krgbBtnJoin.Click += new System.EventHandler(this.krgbBtnJoin_Click);
            // 
            // krgbBtnExtract
            // 
            this.krgbBtnExtract.ImageLarge = global::WaMarketProApp.Properties.Resources.group2_64;
            this.krgbBtnExtract.ImageSmall = global::WaMarketProApp.Properties.Resources.group_16;
            this.krgbBtnExtract.TextLine1 = "Extract";
            this.krgbBtnExtract.Click += new System.EventHandler(this.krgbBtnExtract_Click);
            // 
            // krgbBtnGroupSend
            // 
            this.krgbBtnGroupSend.ImageLarge = global::WaMarketProApp.Properties.Resources.send1_641;
            this.krgbBtnGroupSend.ImageSmall = global::WaMarketProApp.Properties.Resources.send1_16;
            this.krgbBtnGroupSend.TextLine1 = "Send";
            this.krgbBtnGroupSend.Click += new System.EventHandler(this.krgbBtnGroupSend_Click);
            // 
            // krbReply
            // 
            this.krbReply.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            this.krbReply.TextLine1 = "Auto Reply";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbBtnReplyMsg,
            this.krgbBtnReply});
            // 
            // krgbBtnReplyMsg
            // 
            this.krgbBtnReplyMsg.ImageLarge = global::WaMarketProApp.Properties.Resources.bot_message_64;
            this.krgbBtnReplyMsg.ImageSmall = global::WaMarketProApp.Properties.Resources.bot_message_16;
            this.krgbBtnReplyMsg.TextLine1 = "Reply Msg";
            this.krgbBtnReplyMsg.Click += new System.EventHandler(this.krgbBtnReplyMsg_Click);
            // 
            // krgbBtnReply
            // 
            this.krgbBtnReply.ImageLarge = global::WaMarketProApp.Properties.Resources.bot_64;
            this.krgbBtnReply.ImageSmall = global::WaMarketProApp.Properties.Resources.bot_16;
            this.krgbBtnReply.TextLine1 = "Auto Reply";
            this.krgbBtnReply.Click += new System.EventHandler(this.krgbBtnReply_Click);
            // 
            // krtSetting
            // 
            this.krtSetting.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.krgLang});
            this.krtSetting.Text = "Setting";
            // 
            // krgLang
            // 
            this.krgLang.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.krgComTriple});
            this.krgLang.MaximumWidth = 200;
            this.krgLang.MinimumWidth = 200;
            this.krgLang.TextLine1 = "Language";
            // 
            // krgComTriple
            // 
            this.krgComTriple.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgComLang});
            // 
            // krgComLang
            // 
            this.krgComLang.DropDownHeight = 500;
            this.krgComLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krgComLang.DropDownWidth = 260;
            this.krgComLang.FormattingEnabled = false;
            this.krgComLang.ItemHeight = 23;
            this.krgComLang.MinimumSize = new System.Drawing.Size(160, 0);
            this.krgComLang.Text = "";
            this.krgComLang.SelectedIndexChanged += new System.EventHandler(this.krgComLang_SelectedIndexChanged);
            // 
            // krtAbout
            // 
            this.krtAbout.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.krgAbout});
            this.krtAbout.Text = "About";
            // 
            // krgAbout
            // 
            this.krgAbout.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple9});
            this.krgAbout.TextLine1 = "About";
            // 
            // kryptonRibbonGroupTriple9
            // 
            this.kryptonRibbonGroupTriple9.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbBtnWa,
            this.krgbBtnFollow,
            this.krgbBtnAbout});
            // 
            // krgbBtnWa
            // 
            this.krgbBtnWa.ImageLarge = global::WaMarketProApp.Properties.Resources.wa2_64;
            this.krgbBtnWa.ImageSmall = global::WaMarketProApp.Properties.Resources.wa2_16;
            this.krgbBtnWa.TextLine1 = "Help";
            // 
            // krgbBtnFollow
            // 
            this.krgbBtnFollow.ImageLarge = global::WaMarketProApp.Properties.Resources.follow_64;
            this.krgbBtnFollow.ImageSmall = global::WaMarketProApp.Properties.Resources.follow_16;
            this.krgbBtnFollow.TextLine1 = "Follow Us";
            this.krgbBtnFollow.Click += new System.EventHandler(this.krgbBtnFollow_Click);
            // 
            // krgbBtnAbout
            // 
            this.krgbBtnAbout.ImageLarge = global::WaMarketProApp.Properties.Resources.about_64;
            this.krgbBtnAbout.ImageSmall = global::WaMarketProApp.Properties.Resources.about_16;
            this.krgbBtnAbout.TextLine1 = "About";
            this.krgbBtnAbout.Click += new System.EventHandler(this.krgbBtnAbout_Click);
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Bar.BarMapExtraText = Krypton.Navigator.MapKryptonPageText.None;
            this.kryptonNavigator1.Bar.BarMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonNavigator1.Bar.BarMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonNavigator1.Bar.BarMultiline = Krypton.Navigator.BarMultiline.Singleline;
            this.kryptonNavigator1.Bar.BarOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonNavigator1.Bar.CheckButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonNavigator1.Bar.ItemAlignment = Krypton.Toolkit.RelativePositionAlign.Near;
            this.kryptonNavigator1.Bar.ItemMaximumSize = new System.Drawing.Size(200, 200);
            this.kryptonNavigator1.Bar.ItemMinimumSize = new System.Drawing.Size(20, 20);
            this.kryptonNavigator1.Bar.ItemOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.kryptonNavigator1.Bar.ItemSizing = Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.kryptonNavigator1.Bar.TabBorderStyle = Krypton.Toolkit.TabBorderStyle.RoundedOutsizeMedium;
            this.kryptonNavigator1.Bar.TabStyle = Krypton.Toolkit.TabStyle.HighProfile;
            this.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose;
            this.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage;
            this.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Size = new System.Drawing.Size(1360, 841);
            this.kryptonNavigator1.TabIndex = 1;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslabStatus,
            this.toolStripStatusLabel3,
            this.tsslabPhone});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1000);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1360, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 25);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // tsslabStatus
            // 
            this.tsslabStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslabStatus.ForeColor = System.Drawing.Color.Red;
            this.tsslabStatus.Name = "tsslabStatus";
            this.tsslabStatus.Size = new System.Drawing.Size(90, 25);
            this.tsslabStatus.Text = "NoLogin";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(140, 25);
            this.toolStripStatusLabel3.Text = "PhoneNumber:";
            // 
            // tsslabPhone
            // 
            this.tsslabPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslabPhone.Name = "tsslabPhone";
            this.tsslabPhone.Size = new System.Drawing.Size(0, 25);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 159);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1360, 841);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 1032);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.kryptonRibbon1);
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp Bulk Sender | Group Sender |Auto Reply Pro";
            this.TextExtra = "3.2.4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonGroup krbMessage;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnLogin;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnMessage;
        private Krypton.Ribbon.KryptonRibbonGroup krgContact;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnFilter;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnContactSend;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnPhoneSend;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnJoin;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnExtract;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnGroupSend;
        private Krypton.Ribbon.KryptonRibbonGroup krbReply;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnReplyMsg;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnReply;
        private Krypton.Ribbon.KryptonRibbonTab krtSetting;
        private Krypton.Ribbon.KryptonRibbonTab krtAbout;
        private Krypton.Ribbon.KryptonRibbonGroup krgLang;
        private Krypton.Ribbon.KryptonRibbonGroupTriple krgComTriple;
        private Krypton.Ribbon.KryptonRibbonGroup krgAbout;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple9;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnFollow;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslabPhone;
        private Krypton.Ribbon.KryptonRibbonGroupComboBox krgComLang;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbBtnWa;
    }
}

