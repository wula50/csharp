namespace 例5._6
{
    partial class FrmMain
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
            this.btnOK = new System.Windows.Forms.Button();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoMul = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblEqu = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(119, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "计算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(43, 51);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(29, 16);
            this.rdoAdd.TabIndex = 6;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "+";
            this.rdoAdd.UseVisualStyleBackColor = true;
            this.rdoAdd.CheckedChanged += new System.EventHandler(this.rdoAdd_CheckedChanged);
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(110, 51);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(29, 16);
            this.rdoSub.TabIndex = 7;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "-";
            this.rdoSub.UseVisualStyleBackColor = true;
            this.rdoSub.CheckedChanged += new System.EventHandler(this.rdoSub_CheckedChanged);
            // 
            // rdoMul
            // 
            this.rdoMul.AutoSize = true;
            this.rdoMul.Location = new System.Drawing.Point(177, 51);
            this.rdoMul.Name = "rdoMul";
            this.rdoMul.Size = new System.Drawing.Size(29, 16);
            this.rdoMul.TabIndex = 8;
            this.rdoMul.TabStop = true;
            this.rdoMul.Text = "*";
            this.rdoMul.UseVisualStyleBackColor = true;
            this.rdoMul.CheckedChanged += new System.EventHandler(this.rdoMul_CheckedChanged);
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(244, 51);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(29, 16);
            this.rdoDiv.TabIndex = 9;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "/";
            this.rdoDiv.UseVisualStyleBackColor = true;
            this.rdoDiv.CheckedChanged += new System.EventHandler(this.rdoDiv_CheckedChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(28, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(44, 21);
            this.txtNum1.TabIndex = 10;
            this.txtNum1.Text = "0";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(97, 16);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(41, 12);
            this.lblOperator.TabIndex = 11;
            this.lblOperator.Text = "运算符";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(163, 12);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(44, 21);
            this.txtNum2.TabIndex = 12;
            this.txtNum2.Text = "0";
            // 
            // lblEqu
            // 
            this.lblEqu.AutoSize = true;
            this.lblEqu.Location = new System.Drawing.Point(232, 16);
            this.lblEqu.Name = "lblEqu";
            this.lblEqu.Size = new System.Drawing.Size(11, 12);
            this.lblEqu.TabIndex = 13;
            this.lblEqu.Text = "=";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(268, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "结果";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 132);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEqu);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.rdoDiv);
            this.Controls.Add(this.rdoMul);
            this.Controls.Add(this.rdoSub);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "根据所选择的符号，进行运算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoMul;
        private System.Windows.Forms.RadioButton rdoDiv;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblEqu;
        private System.Windows.Forms.Label lblResult;

    }
}

