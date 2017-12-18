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
    public partial class frmSpend : Form
    {
        SpendManage spendManage;

        public frmSpend()
        {
            InitializeComponent();
            spendManage = new SpendManage();
        }

        private void frmSpend_Load(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Now.ToShortTimeString();
            //窗体打开时，显示现有的支出记录，按日期排序           
            dgvSpend.DataSource = spendManage.GetSpendList();
            dgvSpend.Columns[0].Visible = false;

            //在dgvSpend中的每一行显示两个按钮实现修改和删除
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();            
            btn1.Width = 50;
            btn1.HeaderText = "操作1";
            btn1.DefaultCellStyle.NullValue = "修改";
            dgvSpend.Columns.Add(btn1);
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();          
            btn2.Width = 50;
            btn2.HeaderText = "操作2";
            btn2.DefaultCellStyle.NullValue = "删除";
            dgvSpend.Columns.Add(btn2);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //确认添加一条新记录           
            Spend newSpend = new Spend();
            newSpend.日期 = DateTime.Parse(dtDate.Text);
            newSpend.金额 = float.Parse(txtMoney.Text);
            newSpend.用途 = txtUseFor.Text;
            if (spendManage.AddSpend(newSpend))
            {
                txtMoney.Text = "";
                dtDate.Text = DateTime.Now.ToShortTimeString();
                txtUseFor.Text = "";
                MessageBox.Show("添加成功", "提示");
                dgvSpend.DataSource = spendManage.GetSpendList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //取消添加的内容
            txtUseFor.Text = "";
            txtMoney.Text = "";
            dtDate.Text = DateTime.Today.ToShortDateString();
        }

        private void dgvSpend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int spendID;
            spendID = Convert.ToInt32(dgvSpend.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 0)
            {
                frmEditSpend frmEdit = new frmEditSpend(spendID);
                frmEdit.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                if (spendManage.DelSpend(spendID))
                    MessageBox.Show("删除成功！");
                else
                    MessageBox.Show("删除失败！");                
            }
            dgvSpend.DataSource = spendManage.GetSpendList();
        }
    }
}
