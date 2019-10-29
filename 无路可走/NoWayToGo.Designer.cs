namespace 无路可走
{
    partial class NoWayToGo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoWayToGo));
            this.BTStart = new System.Windows.Forms.Button();
            this.BTClose = new System.Windows.Forms.Button();
            this.LBRestart = new System.Windows.Forms.Label();
            this.LBClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTStart
            // 
            this.BTStart.Location = new System.Drawing.Point(213, 175);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(75, 23);
            this.BTStart.TabIndex = 0;
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // BTClose
            // 
            this.BTClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTClose.Location = new System.Drawing.Point(333, 175);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(75, 23);
            this.BTClose.TabIndex = 1;
            this.BTClose.UseVisualStyleBackColor = true;
            this.BTClose.Click += new System.EventHandler(this.BTClose_Click);
            // 
            // LBRestart
            // 
            this.LBRestart.AutoSize = true;
            this.LBRestart.Location = new System.Drawing.Point(227, 226);
            this.LBRestart.Name = "LBRestart";
            this.LBRestart.Size = new System.Drawing.Size(167, 15);
            this.LBRestart.TabIndex = 2;
            this.LBRestart.Text = "按下ENTER重新开始游戏";
            this.LBRestart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBClose
            // 
            this.LBClose.AutoSize = true;
            this.LBClose.Location = new System.Drawing.Point(247, 274);
            this.LBClose.Name = "LBClose";
            this.LBClose.Size = new System.Drawing.Size(121, 15);
            this.LBClose.TabIndex = 3;
            this.LBClose.Text = "按下ESC退出游戏";
            this.LBClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoWayToGo
            // 
            this.AcceptButton = this.BTStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTClose;
            this.ClientSize = new System.Drawing.Size(633, 497);
            this.Controls.Add(this.LBClose);
            this.Controls.Add(this.LBRestart);
            this.Controls.Add(this.BTClose);
            this.Controls.Add(this.BTStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoWayToGo";
            this.Text = "NoWayToGo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NoWayToGo_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoWayToGo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NoWayToGo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NoWayToGo_MouseUp);
            this.Resize += new System.EventHandler(this.NoWayToGo_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.Button BTClose;
        private System.Windows.Forms.Label LBRestart;
        private System.Windows.Forms.Label LBClose;
    }
}

