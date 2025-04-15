namespace WaMarketProApp
{
    partial class FrmAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuth));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtPurchaseCode = new Krypton.Toolkit.KryptonRichTextBox();
            this.labMsg = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.btnAuth = new Krypton.Toolkit.KryptonButton();
            this.btnHelp = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtDeviceId = new Krypton.Toolkit.KryptonTextBox();
            this.btnCopy = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(703, 511);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPurchaseCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labMsg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDeviceId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 511);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(2, 66);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(101, 29);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Active Key:";
            // 
            // txtPurchaseCode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPurchaseCode, 2);
            this.txtPurchaseCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPurchaseCode.Location = new System.Drawing.Point(177, 66);
            this.txtPurchaseCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchaseCode.Name = "txtPurchaseCode";
            this.txtPurchaseCode.Size = new System.Drawing.Size(524, 371);
            this.txtPurchaseCode.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtPurchaseCode.TabIndex = 3;
            this.txtPurchaseCode.Text = "";
            // 
            // labMsg
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.labMsg, 3);
            this.labMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMsg.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.labMsg.Location = new System.Drawing.Point(2, 2);
            this.labMsg.Margin = new System.Windows.Forms.Padding(2);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(699, 28);
            this.labMsg.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.labMsg.TabIndex = 6;
            this.labMsg.Values.Text = "Info";
            // 
            // kryptonPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kryptonPanel2, 3);
            this.kryptonPanel2.Controls.Add(this.btnAuth);
            this.kryptonPanel2.Controls.Add(this.btnHelp);
            this.kryptonPanel2.Controls.Add(this.btnClose);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(2, 441);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(699, 68);
            this.kryptonPanel2.TabIndex = 7;
            // 
            // btnAuth
            // 
            this.btnAuth.CornerRoundingRadius = -1F;
            this.btnAuth.Location = new System.Drawing.Point(175, 10);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(115, 51);
            this.btnAuth.TabIndex = 4;
            this.btnAuth.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAuth.Values.Image")));
            this.btnAuth.Values.Text = "Auth";
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.CornerRoundingRadius = -1F;
            this.btnHelp.Location = new System.Drawing.Point(573, 10);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 51);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Values.Image")));
            this.btnHelp.Values.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.CornerRoundingRadius = -1F;
            this.btnClose.Location = new System.Drawing.Point(294, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 51);
            this.btnClose.TabIndex = 5;
            this.btnClose.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Values.Image")));
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 34);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(87, 28);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "DeviceId:";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeviceId.Location = new System.Drawing.Point(177, 34);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(417, 31);
            this.txtDeviceId.TabIndex = 9;
            // 
            // btnCopy
            // 
            this.btnCopy.CornerRoundingRadius = -1F;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Location = new System.Drawing.Point(598, 34);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(103, 28);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Values.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FrmAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 511);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAuth_FormClosed);
            this.Load += new System.EventHandler(this.FrmAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonRichTextBox txtPurchaseCode;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnAuth;
        private Krypton.Toolkit.KryptonLabel labMsg;
        private Krypton.Toolkit.KryptonButton btnHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtDeviceId;
        private Krypton.Toolkit.KryptonButton btnCopy;
    }
}