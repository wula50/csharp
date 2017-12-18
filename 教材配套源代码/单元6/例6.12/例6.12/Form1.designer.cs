namespace 例6._12
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYy = new System.Windows.Forms.TextBox();
            this.txtSx = new System.Windows.Forms.TextBox();
            this.txtYw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtWl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtYy);
            this.panel1.Controls.Add(this.txtSx);
            this.panel1.Controls.Add(this.txtYw);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(347, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 181);
            this.panel1.TabIndex = 5;
            // 
            // txtHx
            // 
            this.txtHx.Location = new System.Drawing.Point(37, 149);
            this.txtHx.Name = "txtHx";
            this.txtHx.Size = new System.Drawing.Size(100, 21);
            this.txtHx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "化学";
            // 
            // txtWl
            // 
            this.txtWl.Location = new System.Drawing.Point(37, 118);
            this.txtWl.Name = "txtWl";
            this.txtWl.Size = new System.Drawing.Size(100, 21);
            this.txtWl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "物理";
            // 
            // txtYy
            // 
            this.txtYy.Location = new System.Drawing.Point(37, 87);
            this.txtYy.Name = "txtYy";
            this.txtYy.Size = new System.Drawing.Size(100, 21);
            this.txtYy.TabIndex = 5;
            // 
            // txtSx
            // 
            this.txtSx.Location = new System.Drawing.Point(37, 54);
            this.txtSx.Name = "txtSx";
            this.txtSx.Size = new System.Drawing.Size(100, 21);
            this.txtSx.TabIndex = 4;
            // 
            // txtYw
            // 
            this.txtYw.Location = new System.Drawing.Point(37, 20);
            this.txtYw.Name = "txtYw";
            this.txtYw.Size = new System.Drawing.Size(100, 21);
            this.txtYw.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "英语";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数学";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "语文";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(319, 181);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(222, 199);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 231);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYy;
        private System.Windows.Forms.TextBox txtSx;
        private System.Windows.Forms.TextBox txtYw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
    }
}