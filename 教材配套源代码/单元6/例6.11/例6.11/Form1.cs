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

namespace 例6._11
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

        private void Form2_Load(object sender, EventArgs e)
        {
            string strsql = "select ID as 学号, name as 姓名, age as 年龄 from T_Stu";
            SqlDataAdapter da;
            DataSet ds=new DataSet();
            da = new SqlDataAdapter(strsql, strcon);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

