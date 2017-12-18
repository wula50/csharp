using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnk163_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnk163.LinkVisited = true;
            System.Diagnostics.Process.Start(lnk163.Text.Substring(3, 11));
        }
    }
}
