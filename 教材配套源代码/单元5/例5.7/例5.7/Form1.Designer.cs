namespace 例5._7
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblMul = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(46, 60);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(43, 21);
            this.txtNum1.TabIndex = 0;
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(127, 23);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(30, 16);
            this.chkAdd.TabIndex = 2;
            this.chkAdd.Text = "+";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(127, 46);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(30, 16);
            this.chkSub.TabIndex = 3;
            this.chkSub.Text = "-";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(127, 69);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(30, 16);
            this.chkMul.TabIndex = 4;
            this.chkMul.Text = "*";
            this.chkMul.UseVisualStyleBackColor = true;
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(127, 92);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(30, 16);
            this.chkDiv.TabIndex = 5;
            this.chkDiv.Text = "/";
            this.chkDiv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(271, 23);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(29, 12);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "结果";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(271, 46);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(29, 12);
            this.lblSub.TabIndex = 8;
            this.lblSub.Text = "结果";
            // 
            // lblMul
            // 
            this.lblMul.AutoSize = true;
            this.lblMul.Location = new System.Drawing.Point(271, 69);
            this.lblMul.Name = "lblMul";
            this.lblMul.Size = new System.Drawing.Size(29, 12);
            this.lblMul.TabIndex = 9;
            this.lblMul.Text = "结果";
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Location = new System.Drawing.Point(271, 92);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(29, 12);
            this.lblDiv.TabIndex = 10;
            this.lblDiv.Text = "结果";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(177, 60);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(43, 21);
            this.txtNum2.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "计算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 179);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.lblMul);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDiv);
            this.Controls.Add(this.chkMul);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "基于多选符号的四则运算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblMul;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnOK;
    }
}