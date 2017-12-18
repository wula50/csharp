using System;
using System.Windows.Forms;

namespace RegisterUI
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private void lnkProtocol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Form();
            f.Text = "用户协议";
            f.ShowDialog();
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = chkAgree.Checked;
        }

        private void btnEixt_Click(object sender, EventArgs e)
        { this.Close(); }

        private void Form1_Load(object sender, EventArgs e)
        { comboDateType.SelectedIndex = 0;/*初始化时选中“公历”*/        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInput()) return;

            string info = "";
            info += "用户名：" + txtName.Text.Trim() + "\n";
            info += "密码：" + txtPwd.Text.Trim() + "\n";
            info += "性别：" + this.GetSexInput() + "\n";
            info += "生日：" + comboDateType.Text + " " + dtpDayOfBirth.Value.ToShortDateString() + "\n";
            info += "电子邮件：" + txtEmail.Text.Trim() + "\n";
            info += "喜爱的编程语言：" + this.GetFavorLangInput() + "\n";
            info += "爱好：" + this.GetHobbiesInput() + "\n";

            MessageBox.Show(info, "确认你的注册信息");
        }

        bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("用户名必须填写！");
                return false;
            }

            if (txtPwd.Text.Trim() != txtPwd2.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致！");
                return false;
            }

            return true; ;
        }
        //获取性别输入
        string GetSexInput()
        {
            if (rdoFemale.Checked)
                return rdoFemale.Text;
            else if (rdoMale.Checked)
                return rdoMale.Text;
            else
                return rdoSexUnkown.Text;
        }
        //获取“你喜欢的编程语言”输入
        string GetFavorLangInput()
        {
            string str = "";
            foreach (object item in lstbxFavorLang.SelectedItems)
            { str += item.ToString() + "，"; }

            if (str.LastIndexOf('，') > 0)
            { str = str.Remove(str.LastIndexOf('，'));/*移除最后一个逗号*/ }

            return str;
        }
        //获取“你的爱好”输入
        string GetHobbiesInput()
        {
            string str = "";
            foreach (object item in chklstHobbies.CheckedItems)//注意Checked和Selected之间的差别
            { str += item.ToString() + "，"; }

            if (str.LastIndexOf('，') > 0)
            { str = str.Remove(str.LastIndexOf('，'));/*移除最后一个逗号*/ }

            return str;
        }
    }
}
