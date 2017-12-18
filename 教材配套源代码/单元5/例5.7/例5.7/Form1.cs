using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNum1.Text);
            int j = int.Parse(txtNum2.Text);

            if (chkAdd.Checked)
            {
                lblAdd.Text = (i + j).ToString();
            }
            else
            {
                lblAdd.Text = "";
            }

            if (chkSub.Checked)
            {
                lblSub.Text = (i - j).ToString();
            }
            else
            {
                lblSub.Text = "";
            }

            if (chkMul.Checked)
            {
                lblMul.Text = (i * j).ToString();
            }
            else
            {
                lblMul.Text = "";
            }

            if (chkDiv.Checked)
            {
                if (j != 0)
                {
                    lblDiv.Text = (i * 1.0 / j).ToString();
                }
                else
                {
                    lblDiv.Text = "除数为0";
                }

            }
            else 
            {
                lblDiv.Text = "";
            }
        }
    }
}
