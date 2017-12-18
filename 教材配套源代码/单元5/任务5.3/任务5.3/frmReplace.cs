using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class frmReplace : Form
    {
        public frmReplace()
        {
            InitializeComponent();
        }

        public int count = 0;
        public int a, b;

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyword.Text != null)
            {
                txtSearch.Enabled = true;
                btnReplaceOne.Enabled = true;
                btnReplaceAll.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.Owner;
            a = f.rtb1.Text.IndexOf(txtKeyword.Text, count);
            if (a >= 0)
            {
                f.rtb1.Select(a, txtKeyword.Text.Length);
                f.rtb1.Focus();
                count = a + 1;
            }
            else
            {
                MessageBox.Show(this.Owner, "找不到" + "\"" + txtKeyword.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnReplaceOne_Click(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.Owner;
            a = f.rtb1.Text.IndexOf(txtKeyword.Text, count);
            if (a >= 0)
            {
                f.rtb1.Text = f.rtb1.Text.Remove(a, txtKeyword.Text.Length);
                f.rtb1.Text = f.TextContent.Insert(a, txtReplacement.Text);
            }
            else
            {
                MessageBox.Show(this.Owner, "找不到" + "\"" + txtKeyword.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            frmMain f1 = (frmMain)this.Owner;
            f1.rtb1.Text = f1.rtb1.Text.Replace(txtKeyword.Text, txtReplacement.Text);
        }
    }
}
