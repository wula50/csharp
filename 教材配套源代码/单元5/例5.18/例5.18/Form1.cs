using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例5._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login1_UserVerified(object sender, UserVerifiedEventArgs e)
        {
            if (e.Authorized)
                MessageBox.Show("登录成功！");
            else
                MessageBox.Show("用户名或密码错误！");
        }
    }
}
