using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsBtnIncome_Click(object sender, EventArgs e)
        {
            frmIncome incomeForm = new frmIncome();
            incomeForm.MdiParent = this;
            incomeForm.Show();
        }

        private void tsBtnSpend_Click(object sender, EventArgs e)
        {
            frmSpend spendForm = new frmSpend();
            spendForm.MdiParent = this;
            spendForm.Show();
        }

        private void tsBtnView_Click(object sender, EventArgs e)
        {
            frmView viewForm = new frmView();
            viewForm.MdiParent = this;
            viewForm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出系统", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)            
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
