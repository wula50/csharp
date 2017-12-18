namespace MyAccounting
{
    partial class frmView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSpend = new System.Windows.Forms.DataGridView();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.dtDate2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDate1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiffer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSpend = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSpend);
            this.groupBox1.Controls.Add(this.dgvIncome);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.dtDate2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtDate1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvSpend
            // 
            this.dgvSpend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpend.Location = new System.Drawing.Point(332, 57);
            this.dgvSpend.Name = "dgvSpend";
            this.dgvSpend.RowTemplate.Height = 23;
            this.dgvSpend.Size = new System.Drawing.Size(294, 192);
            this.dgvSpend.TabIndex = 14;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(16, 57);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowTemplate.Height = 23;
            this.dgvIncome.Size = new System.Drawing.Size(294, 192);
            this.dgvIncome.TabIndex = 13;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(402, 17);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 12;
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtDate2
            // 
            this.dtDate2.Location = new System.Drawing.Point(243, 17);
            this.dtDate2.Name = "dtDate2";
            this.dtDate2.Size = new System.Drawing.Size(136, 21);
            this.dtDate2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "到";
            // 
            // dtDate1
            // 
            this.dtDate1.Location = new System.Drawing.Point(78, 17);
            this.dtDate1.Name = "dtDate1";
            this.dtDate1.Size = new System.Drawing.Size(136, 21);
            this.dtDate1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "时间范围";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDiffer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblSpend);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblIncome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "统计";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "元";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "元";
            // 
            // lblDiffer
            // 
            this.lblDiffer.AutoSize = true;
            this.lblDiffer.Location = new System.Drawing.Point(430, 31);
            this.lblDiffer.Name = "lblDiffer";
            this.lblDiffer.Size = new System.Drawing.Size(0, 12);
            this.lblDiffer.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "差额";
            // 
            // lblSpend
            // 
            this.lblSpend.AutoSize = true;
            this.lblSpend.Location = new System.Drawing.Point(236, 31);
            this.lblSpend.Name = "lblSpend";
            this.lblSpend.Size = new System.Drawing.Size(0, 12);
            this.lblSpend.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "支出";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(51, 31);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(0, 12);
            this.lblIncome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "收入";
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "收支统计";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSpend;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DateTimePicker dtDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblDiffer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSpend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;

    }
}