using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 项目实训6._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
         
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
        {
        }
        //
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

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

        private void Form2_Load(object sender, EventArgs e)
        {
            InitTree();//初始化Treeview
        }

        private void tree_DoubleClick(object sender, EventArgs e)
        {
            //实现在列表视图控件中双击打开文件功能
            foreach (ListViewItem file in list.SelectedItems)
            { System.Diagnostics.Process.Start(file.Tag.ToString()); }
        }
    }
}
