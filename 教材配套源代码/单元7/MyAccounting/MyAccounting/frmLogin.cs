using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAccounting.BLL;
using MyAccounting.Models;

namespace MyAccounting
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtUserPwd.Text.Trim() == "")
                MessageBox.Show("用户名或密码为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                User u=new User(txtUserName.Text.Trim(),txtUserPwd.Text.Trim());
                if(UserManage.ValidataUser(u))
                {
                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
