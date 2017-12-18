namespace 例5._13
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("入门经典");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("高级编程");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("C#");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("程序设计语言", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("自控力");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("拖延心理学");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("个人管理", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("个人图书馆", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 32);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点4";
            treeNode1.Text = "入门经典";
            treeNode2.Name = "节点5";
            treeNode2.Text = "高级编程";
            treeNode3.Name = "节点0";
            treeNode3.Text = "C#";
            treeNode4.Name = "节点1";
            treeNode4.Text = "程序设计语言";
            treeNode5.Name = "节点6";
            treeNode5.Text = "自控力";
            treeNode6.Name = "节点7";
            treeNode6.Text = "拖延心理学";
            treeNode7.Name = "节点2";
            treeNode7.Text = "个人管理";
            treeNode8.Name = "节点0";
            treeNode8.Text = "个人图书馆";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(190, 189);
            this.treeView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加\r\n";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(222, 47);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 21);
            this.txtBookName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "添加的图书：\r\n";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(247, 139);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "删除\r\n\r\n\r\n";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
    }
}

