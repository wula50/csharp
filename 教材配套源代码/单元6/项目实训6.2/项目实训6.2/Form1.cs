using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace 项目实训6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();//初始化Treeview
        }

        #region 处理树视图控件的事件

        //初始化Treeview控件
        void InitTree()
        {
            TreeNode root = new TreeNode("计算机");
            root.Tag = "计算机";
            root.SelectedImageKey = root.ImageKey = "computer";
            tree.Nodes.Add(root);

            try
            {
                string[] drives = Directory.GetLogicalDrives();
                foreach (string drv in drives)
                {
                    DriveInfo drvInfo = new DriveInfo(drv);
                    if (drvInfo.DriveType == DriveType.Fixed)
                    {
                        TreeNode node = new TreeNode();
                        node.Tag = drvInfo.Name;
                        node.Text = drvInfo.VolumeLabel + "(" + drvInfo.Name + ")";
                        node.SelectedImageKey = node.ImageKey = "folder";
                        root.Nodes.Add(node);
                        LoadTree(node, node.Tag.ToString(), 1);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            root.Expand();
        }
        //
        void LoadTree(TreeNode node, string dir, int level)
        { //文件夹dir和树上节点node对应,采用递归算法把dir下面的level层子文件夹
            //装载到树上的node节点下
            if (level <= 0 || dir == "计算机") { return; }

            node.Nodes.Clear();

            try
            {
                string[] subdirs = Directory.GetDirectories(dir);
                foreach (string subdir in subdirs)
                {
                    TreeNode temp = new TreeNode();
                    //将文件夹名称显示为节点文本
                    temp.Text = Path.GetFileName(subdir);
                    //将文件夹完整路径作为object存储在Tag属性中备用
                    temp.Tag = subdir;
                    node.Nodes.Add(temp);
                    temp.SelectedImageKey = temp.ImageKey = "folder";
                    LoadTree(temp, subdir, level - 1);
                }
            }
            catch (UnauthorizedAccessException)
            { /*捕获但不处理文件夹无法访问的异常*/ }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        //
        private void tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {//在展开节点之前将该节点下面的两层子节点载入
            tree.BeginUpdate();
            LoadTree(e.Node, e.Node.Tag.ToString(), 2);
            tree.EndUpdate();
        }
        //
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag.ToString() != "计算机")
            {
                string dir = e.Node.Tag.ToString();
                this.Text = dir;//将当前文件夹路径显示在窗口标题栏中
                FillListView(e.Node);
                //txtSubdirNum.Text = "子文件夹数：" + Directory.GetDirectories(dir).Length;
                //txtFileNum.Text = "文件数：" + Directory.GetFiles(dir).Length;
            }
            else
            {
                FillListView(e.Node);
                //txtFileNum.Text = "文件数：0";
                //txtSubdirNum.Text = "子文件夹数：0";
            }

            if (e.Node.Parent == null)
                btnUp.Enabled = false;
            else
                btnUp.Enabled = true;
        }
        //
        void FillListView(TreeNode node)
        {//将Treeview指定节点下的文件显示在ListView中
            if (node.Tag == null) return;

            string dir = node.Tag.ToString();
            list.Items.Clear();

            if (!Directory.Exists(dir)) return;
            try
            {
                string[] files = Directory.GetFiles(dir);
                FileSystemInfo fs = new FileInfo(node.Tag.ToString());

                foreach (string path in files)
                {
                    if (File.Exists(path))
                    {
                        FileInfo info = new FileInfo(path);
                        ListViewItem item = new ListViewItem(info.Name);
                        item.SubItems.Add(info.Extension == "" ? ".file" : info.Extension);
                        item.SubItems.Add(info.LastAccessTime.ToString());
                        item.SubItems.Add(info.CreationTime.ToString());
                        item.SubItems.Add(info.LastWriteTime.ToString());
                        item.SubItems.Add(info.Length.ToString());
                        item.ImageKey = "file";
                        item.Tag = path;
                        list.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region 右键菜单功能实现

        string selectedFile = "";  //保存在剪切、复制时的文件路径
        bool cutFlag = true;
        bool copyFlag = false;
        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutFlag = true;
            copyFlag = false;
            粘贴ToolStripMenuItem.Enabled = true;
            if (list.SelectedItems.Count > 0)
            { this.selectedFile = list.SelectedItems[0].Tag.ToString(); }
        }
        //
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutFlag = false;
            copyFlag = true;
            粘贴ToolStripMenuItem.Enabled = true;

            if (list.SelectedItems.Count > 0)
            { this.selectedFile = list.SelectedItems[0].Tag.ToString(); }
        }
        //
        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFile == "") { return; }

            try
            {
                string newFilePath = Path.Combine(tree.SelectedNode.Tag.ToString(),
                    Path.GetFileName(selectedFile));

                if (cutFlag)
                {
                    File.Move(selectedFile, newFilePath);
                    cutFlag = false;
                }
                else if (copyFlag)
                {
                    File.Copy(selectedFile, newFilePath);
                    copyFlag = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "操作失败："); }
            finally
            {
                selectedFile = "";
                粘贴ToolStripMenuItem.Enabled = false;
                FillListView(tree.SelectedNode);
            }
        }
        //
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedFile = list.SelectedItems[0].Tag.ToString();

                if (MessageBox.Show("你确定要删除文件" + Path.GetFileName(selectedFile) + "?",
                    "删除文件?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(selectedFile);
                }
                selectedFile = "";
                FillListView(tree.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete file. The following exception"
                    + " occurred:\n" + ex.Message, "Failed");
            }
        }
        #endregion

        private void btnUp_Click(object sender, EventArgs e)
        {//“向上”按钮功能实现
            if (tree.SelectedNode != null && tree.SelectedNode.Parent != null)
            { tree.SelectedNode = tree.SelectedNode.Parent; }
        }

        private void list_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {//实现重命名功能
            if (e.Label == null) return;

            try
            {
                string oldFilename = list.SelectedItems[0].Tag.ToString();
                string newFilename = Path.Combine(Path.GetDirectoryName(oldFilename), e.Label);

                File.Move(oldFilename, newFilename);
                list.SelectedItems[0].Tag = newFilename;

                FillListView(tree.SelectedNode);//刷新
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.CancelEdit = true;
            }

        }

        private void list_DoubleClick(object sender, EventArgs e)
        {//实现在列表视图控件中双击打开文件功能
            foreach (ListViewItem file in list.SelectedItems)
            { Process.Start(file.Tag.ToString()); }
        }

    }
}
