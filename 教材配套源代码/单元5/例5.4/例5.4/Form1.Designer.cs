namespace 例5._4
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblEqu = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 21);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(65, 12);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "第一个加数";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(93, 21);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(11, 12);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "+";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(130, 21);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(65, 12);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "第二个加数";
            // 
            // lblEqu
            // 
            this.lblEqu.AutoSize = true;
            this.lblEqu.Location = new System.Drawing.Point(217, 21);
            this.lblEqu.Name = "lblEqu";
            this.lblEqu.Size = new System.Drawing.Size(11, 12);
            this.lblEqu.TabIndex = 3;
            this.lblEqu.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(254, 17);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(74, 21);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "0";
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(85, 66);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 5;
            this.btnQuestion.Text = "出题";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(200, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(335, 21);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 118);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblEqu);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加法练习程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblEqu;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
    }
}

