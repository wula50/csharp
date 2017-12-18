using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            switch (index)
            {
                case 0: MessageBox.Show("进入学号页");
                    break;
                case 1: MessageBox.Show("进入姓名页");
                    break;
                case 2: MessageBox.Show("进入班级页");
                    break;
                case 3: MessageBox.Show("进入年龄页");
                    break;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


    }
}
