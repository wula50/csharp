using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 例6._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True";
            string sqlstr = string.Format("select count(*) from T_User where ID='{0}' and pwd='{1}'", txtID.Text, txtPwd.Text);
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                //使用using语句可保证调用conn的Close方法
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                conn.Open();
                if ((int)cmd.ExecuteScalar() > 0)
                    MessageBox.Show("登录成功！");
                else
                    MessageBox.Show("登录失败！");
            }


            //string sqlstr = "select count(*) from T_User where ID=@id and pwd=@pwd";
            //using (SqlConnection conn = new SqlConnection(connstr))
            //{
            //    使用using语句可保证调用conn的Close方法
            //    SqlCommand cmd = new SqlCommand(sqlstr, conn);
            //    第一个参数
            //    SqlParameter param1 = new SqlParameter("@id", txtID.Text);
            //    cmd.Parameters.Add(param1);
            //    第二个参数
            //    cmd.Parameters.Add("@pwd",SqlDbType.NVarChar).Value=txtPwd.Text;
            //    conn.Open();
            //    if((int)cmd.ExecuteScalar()>0)
            //        MessageBox.Show("登录成功！");
            //    else
            //        MessageBox.Show("登录失败！");                
            //}
        }
    }
}
