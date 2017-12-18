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

namespace 例6._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = @"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\StuDB.mdf;Integrated Security=True";
            string strsql = "select * from T_Stu";
            SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

        }
    }
}
