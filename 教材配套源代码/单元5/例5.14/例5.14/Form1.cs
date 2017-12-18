using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            ColumnHeader cZh = new ColumnHeader();
            cZh.Text = "英文";
            ColumnHeader cCh = new ColumnHeader();
            cCh.Text = "中文";
            listView1.Columns.AddRange(new ColumnHeader[] { cZh, cCh });
            listView1.View = View.Details;
            ListViewItem lvi = new ListViewItem(new string[] { "Dog", "狗" }, -1);
            listView1.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
