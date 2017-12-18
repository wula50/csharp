namespace MyAccounting
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnIncome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSpend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnView = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnIncome,
            this.toolStripSeparator1,
            this.tsBtnSpend,
            this.toolStripSeparator2,
            this.tsBtnView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnIncome
            // 
            this.tsBtnIncome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnIncome.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnIncome.Image")));
            this.tsBtnIncome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnIncome.Name = "tsBtnIncome";
            this.tsBtnIncome.Size = new System.Drawing.Size(23, 22);
            this.tsBtnIncome.Text = "收入";
            this.tsBtnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsBtnIncome.Click += new System.EventHandler(this.tsBtnIncome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSpend
            // 
            this.tsBtnSpend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSpend.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSpend.Image")));
            this.tsBtnSpend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSpend.Name = "tsBtnSpend";
            this.tsBtnSpend.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSpend.Text = "支出";
            this.tsBtnSpend.Click += new System.EventHandler(this.tsBtnSpend_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnView
            // 
            this.tsBtnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnView.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnView.Image")));
            this.tsBtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnView.Name = "tsBtnView";
            this.tsBtnView.Size = new System.Drawing.Size(23, 22);
            this.tsBtnView.Text = "统计";
            this.tsBtnView.ToolTipText = "统计";
            this.tsBtnView.Click += new System.EventHandler(this.tsBtnView_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 437);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnIncome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnSpend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnView;
    }
}