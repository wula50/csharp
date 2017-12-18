using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._6
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int flag = 0;
        private void rdoAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAdd.Checked)
            {
                lblOperator.Text = "+";
                flag = 0;
            }
         
        }

        private void rdoSub_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSub.Checked)
            {
                lblOperator.Text = "-";
                flag = 1;
            }
        }

        private void rdoMul_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMul.Checked)
            {
                lblOperator.Text = "*";
                flag = 2;
            }
        }

        private void rdoDiv_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDiv.Checked)
            {
                lblOperator.Text = "/";
                flag = 3;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i=int.Parse(txtNum1.Text);
            int j=int.Parse(txtNum2.Text);
            switch (flag)
            {
                case 0:lblResult.Text=(i+j).ToString();break;
                case 1:lblResult.Text=(i-j).ToString();break;
                case 2:lblResult.Text=(i*j).ToString();break;
                case 3:
                    if(j!=0) lblResult.Text = (i*1.0 / j).ToString();
                    else lblResult.Text="除数为0"; break;
                
            }
        }
    }
}
