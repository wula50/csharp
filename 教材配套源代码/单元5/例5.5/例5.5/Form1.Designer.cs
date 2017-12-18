namespace 例5._5
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lnk163 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnk163
            // 
            this.lnk163.AutoSize = true;
            this.lnk163.LinkArea = new System.Windows.Forms.LinkArea(3, 11);
            this.lnk163.Location = new System.Drawing.Point(80, 34);
            this.lnk163.Name = "lnk163";
            this.lnk163.Size = new System.Drawing.Size(122, 19);
            this.lnk163.TabIndex = 0;
            this.lnk163.TabStop = true;
            this.lnk163.Text = "网易（www.163.com）";
            this.lnk163.UseCompatibleTextRendering = true;
            this.lnk163.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk163_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.lnk163);
            this.Name = "Form1";
            this.Text = "打开网页";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk163;
    }
}

