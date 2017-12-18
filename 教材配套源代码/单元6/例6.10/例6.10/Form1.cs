using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 例6._10
{
    public partial class Form1 : Form
    {

        SqlDataAdapter da;
        string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\StuDB.mdf;Integrated Security=True;Connect Timeout=30";
        string strsql = "select * from T_Stu";

        public Form1()
        {
            InitializeComponent();
            da = new SqlDataAdapter(strsql, strcon);
        }

        private DataTable getData()
        {
            DataSet dt = new DataSet(); ;
            da.Fill(dt);
            return dt.Tables[0];
        }
        private void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tStu = getData();
                DataRow newRow = tStu.NewRow();
                newRow["ID"] = int.Parse(txtID.Text);
                newRow["name"] = txtName.Text;
                newRow["age"] = int.Parse(txtAge.Text);
                //将新行添加到Rows集合
                tStu.Rows.Add(newRow);

                //为适配器创建Insert命令
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                //使用适配器更新数据集
                da.Update(tStu);
                MessageBox.Show("数据添加成功");
                dataGridView1.DataSource = getData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            try
            {
                int i=dataGridView1.CurrentRow.Index;//获取选中行的索引值
                DataTable tStu = getData();               
                tStu.Rows[i]["name"] = txtName.Text;
                tStu.Rows[i]["age"] = int.Parse(txtAge.Text);                
                //为适配器创建Insert命令
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                //使用适配器更新数据集
                da.Update(tStu);
                MessageBox.Show("数据修改成功");
                dataGridView1.DataSource = getData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            try
            {
                int i = dataGridView1.CurrentRow.Index;//获取选中行的索引值
                DataTable tStu = getData();
                tStu.Rows[i].Delete();

                //为适配器创建Insert命令
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                //使用适配器更新数据集
                da.Update(tStu);
                MessageBox.Show("数据删除成功");
                dataGridView1.DataSource = getData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败");
            }
        }




    }
}
