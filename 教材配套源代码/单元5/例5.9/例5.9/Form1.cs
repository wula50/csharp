using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] human = { "男", "女" };
            listBox1.Items.Add(human[0]);
            listBox1.Items.Add(human[1]);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
