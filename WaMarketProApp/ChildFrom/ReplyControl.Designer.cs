namespace WaMarketProApp.ChildFrom
{
    partial class ReplyControl
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

        #region 

        /// <summary> 
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplyControl));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.txtLogs = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel9 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel7 = new Krypton.Toolkit.KryptonPanel();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnStop = new Krypton.Toolkit.KryptonButton();
            this.btnStart = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1624, 1026);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.txtLogs);
            this.kryptonPanel3.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1624, 1026);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(1624, 926);
            this.txtLogs.TabIndex = 1;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.kryptonPanel9);
            this.kryptonPanel5.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 926);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(1624, 100);
            this.kryptonPanel5.TabIndex = 0;
            // 
            // kryptonPanel9
            // 
            this.kryptonPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel9.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel9.Name = "kryptonPanel9";
            this.kryptonPanel9.Size = new System.Drawing.Size(1180, 100);
            this.kryptonPanel9.TabIndex = 1;
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.btnClear);
            this.kryptonPanel7.Controls.Add(this.btnStop);
            this.kryptonPanel7.Controls.Add(this.btnStart);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel7.Location = new System.Drawing.Point(1180, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(444, 100);
            this.kryptonPanel7.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.CornerRoundingRadius = -1F;
            this.btnClear.Location = new System.Drawing.Point(294, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 63);
            this.btnClear.TabIndex = 14;
            this.btnClear.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Values.Image")));
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.CornerRoundingRadius = -1F;
            this.btnStop.Location = new System.Drawing.Point(160, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 63);
            this.btnStop.TabIndex = 13;
            this.btnStop.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Values.Image")));
            this.btnStop.Values.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.CornerRoundingRadius = -1F;
            this.btnStart.Location = new System.Drawing.Point(29, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 63);
            this.btnStart.TabIndex = 11;
            this.btnStart.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Values.Image")));
            this.btnStart.Values.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ReplyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ReplyControl";
            this.Size = new System.Drawing.Size(1624, 1026);
            this.Load += new System.EventHandler(this.ReplyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonButton btnStop;
        private Krypton.Toolkit.KryptonButton btnStart;
        private Krypton.Toolkit.KryptonPanel kryptonPanel9;
        private Krypton.Toolkit.KryptonTextBox txtLogs;
    }
}
