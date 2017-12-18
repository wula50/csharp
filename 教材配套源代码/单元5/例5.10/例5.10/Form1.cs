using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 2010; i <= 2017; i++)
                cboYear.Items.Add(i);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstYear.Items.Add(cboYear.SelectedItem);
        }
    }
}
