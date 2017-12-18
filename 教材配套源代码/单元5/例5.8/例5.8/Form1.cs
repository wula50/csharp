using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("data.txt");
                MessageBox.Show("成功加载文件！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件还不存在，请先保存！");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("data.txt");
            MessageBox.Show("成功保存文件！");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //查找关键字的起始位置
            int position = richTextBox1.Find(txtKeyword.Text);
            //选中找到的字串
            richTextBox1.Select(position, txtKeyword.Text.Length);
        }
    }
}
