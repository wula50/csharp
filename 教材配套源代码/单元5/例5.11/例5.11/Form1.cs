using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = checkedListBox1.SelectedIndex;
            if (checkedListBox1.CheckOnClick)
            {
                switch (i)
                {
                    case 0:
                        MessageBox.Show("重庆火锅");
                        break;
                    case 1: MessageBox.Show("新疆烤羊腿");
                        break;
                    case 2: MessageBox.Show("豆瓣回锅肉");
                        break;
                    case 3: MessageBox.Show("东坡肉");
                        break;
                    default: MessageBox.Show("不点菜只能饿肚子了哦");
                        break;
                }
            }
        }
    }
}
