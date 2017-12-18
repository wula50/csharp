namespace 例5._18
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
            this.login1 = new 例5._18.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login1.Location = new System.Drawing.Point(13, 13);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(256, 148);
            this.login1.TabIndex = 0;
            this.login1.UserVerified += new 例5._18.UserVerifiedHandler(this.login1_UserVerified);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.login1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Login login1;
    }
}

