using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class frmFind : Form
    {
        public frmFind()
        {
            InitializeComponent();
        }

        public int a;
        public string search;
        public int count = 0;
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmMain fmain = (frmMain)this.Owner;
            string text = fmain.rtb1.Text;

            if (cbxCaseSensitive.Checked == false)
            {
                text = text.ToLower();
            }

            a = text.IndexOf(txtKeyword.Text, count);

            if (a >= 0)
            {
                fmain.rtb1.Select(a, txtKeyword.Text.Length);
                fmain.rtb1.Focus();
                count = a + 1;
            }
            else
            {
                MessageBox.Show(this.Owner, "找不到" + "\"" + txtKeyword.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmFind_Load(object sender, EventArgs e)
        {
           
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyword.Text != null)
                btnFind.Enabled = true;
        }
    }
}
