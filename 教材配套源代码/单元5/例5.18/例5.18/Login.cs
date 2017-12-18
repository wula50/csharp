using System;
using System.Windows.Forms;

namespace 例5._18
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        //定义事件
        public event UserVerifiedHandler UserVerified;

        //定义事件触发方法
        private void OnUserVerfied(UserVerifiedEventArgs e)
        {
             if (UserVerified != null) { UserVerified(this, e); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证输入
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("用户名和密码不能为空！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //创建事件参数对象
            UserVerifiedEventArgs uve = new UserVerifiedEventArgs();

            //验证用户名和密码是否匹配
            if (txtName.Text == "admin" && txtPwd.Text == "123")
            { uve.Authorized = true; }
            else
            { uve.Authorized = false; }
            //触发事件
            OnUserVerfied(uve);
        }
    }

    //定义事件参数类
    public class UserVerifiedEventArgs : EventArgs
    { public bool Authorized { get; set; } }

    //定义事件委托
    public delegate void UserVerifiedHandler(object sender, UserVerifiedEventArgs e);
}


