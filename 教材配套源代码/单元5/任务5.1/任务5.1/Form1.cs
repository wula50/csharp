using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 任务5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPwd.Text == "123")
            {
                MainForm fm = new MainForm();
                this.Hide();
                fm.ShowDialog();//将窗体显示为对话框
                this.Close();
            }
            else
                MessageBox.Show("输入错误，请重新输入！");

        }
    }
}
