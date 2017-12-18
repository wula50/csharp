namespace 例5._2
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
            this.lblMousePosition = new System.Windows.Forms.Label();
            this.lblButton = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.AutoSize = true;
            this.lblMousePosition.Location = new System.Drawing.Point(29, 28);
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Size = new System.Drawing.Size(41, 12);
            this.lblMousePosition.TabIndex = 0;
            this.lblMousePosition.Text = "label1";
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Location = new System.Drawing.Point(29, 58);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(41, 12);
            this.lblButton.TabIndex = 1;
            this.lblButton.Text = "label2";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(29, 89);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 12);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.lblMousePosition);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMousePosition;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label lblKey;
    }
}

