using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Random r;
            r = new Random();
            lblNum1.Text = r.Next(100).ToString();
            lblNum2.Text = r.Next(100).ToString();
            btnQuestion.Enabled = false;
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int result = int.Parse(lblNum1.Text) + int.Parse(lblNum2.Text);
            if (result == int.Parse(txtResult.Text))
            {
                lblResult.Text = "√";
            }
            else
            {
                lblResult.Text = "×";
            }
            btnSubmit.Enabled = false;
            btnQuestion.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
