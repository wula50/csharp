using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Transactions;
using System.Windows.Forms;

namespace 例6._12
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\StuDB.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strsql1 = "select * from T_Stu";
            string strsql2 = "select * from T_Sc";
            SqlDataAdapter da1, da2;
            DataSet ds = new DataSet();
            DataRelation dr;
            da1 = new SqlDataAdapter(strsql1, strcon);
            da2 = new SqlDataAdapter(strsql2, strcon);
            da1.Fill(ds, "学生表");
            da2.Fill(ds, "成绩表");
            dr = new DataRelation("st_sc", ds.Tables["学生表"].Columns["ID"], ds.Tables["成绩表"].Columns["Sno"]);
            ds.Relations.Add(dr);
            int i = dataGridView1.CurrentRow.Index;//获取选中行的索引值
            DataRow row = ds.Tables["学生表"].Rows[i];
            foreach (DataRow rowc in row.GetChildRows("st_sc"))
            {
                switch (rowc["Cno"].ToString())
                {
                    case "001": txtYw.Text = rowc["grade"].ToString(); break;
                    case "002": txtSx.Text = rowc["grade"].ToString(); break;
                    case "003": txtYy.Text = rowc["grade"].ToString(); break;
                    case "004": txtWl.Text = rowc["grade"].ToString(); break;
                    case "005": txtHx.Text = rowc["grade"].ToString(); break;
                }
            }
        }

        private DataTable getData()
        {
            string strsql = "select ID as 学号, name as 姓名, age as 年龄 from T_Stu";
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(strsql, strcon);
            da.Fill(ds);
            return ds.Tables[0];
        }

        private void Clear()
        {
            txtYw.Text = "";
            txtSx.Text = "";
            txtYy.Text = "";
            txtWl.Text = "";
            txtHx.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string strsql1, strsql2;
            int i;
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            i = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            strsql1 = string.Format("delete from T_Sc where Sno={0}", i);
            strsql2 = string.Format("delete from T_Stu where ID={0}", i);

            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();//打开连接后才能调用BeginTransaction方法创建事务
                SqlTransaction trans = conn.BeginTransaction();
                SqlCommand cmd1 = new SqlCommand(strsql1, conn, trans);
                SqlCommand cmd2 = new SqlCommand(strsql2, conn, trans);
                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    trans.Commit();//提交事务
                    MessageBox.Show("删除成功");
                    dataGridView1.DataSource = getData();
                    Clear();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("删除失败\n" + ex.Message);
                }
            }

            //using (SqlConnection conn = new SqlConnection(strcon))
            //{
            //    conn.Open();//打开连接后才能调用BeginTransaction方法创建事务
            //    SqlCommand cmd1 = new SqlCommand(strsql1, conn);
            //    SqlCommand cmd2 = new SqlCommand(strsql2, conn);
            //    using (TransactionScope scope = new TransactionScope())
            //    {
            //        try
            //        {
            //            cmd1.ExecuteNonQuery();
            //            cmd2.ExecuteNonQuery();
            //            dataGridView1.DataSource = getData();
            //            scope.Complete();//指示所有操作都已完成并提交事务 
            //            MessageBox.Show("删除成功");                       
            //            Clear();                      
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("删除失败\n" + ex.Message);
            //        }  
            //    }                
            //}
        }
    }
}
