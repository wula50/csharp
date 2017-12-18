using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Image = imageList1.Images[3];
            label2.Image = imageList1.Images[4];
            label3.Image = imageList1.Images[5];
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            label1.Image = imageList1.Images[3];
            label2.Image = imageList1.Images[4];
            label3.Image = imageList1.Images[5];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            label1.Image = imageList1.Images[0];
            label2.Image = imageList1.Images[1];
            label3.Image = imageList1.Images[2];
        }
    }
}
