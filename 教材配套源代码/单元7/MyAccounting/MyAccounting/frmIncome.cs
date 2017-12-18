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
    public partial class frmIncome : Form
    {
        IncomeManage incomeManage;
        public frmIncome()
        {
            InitializeComponent();
            incomeManage = new IncomeManage();
        }

        private void frmIncome_Load(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Now.ToShortTimeString();
            //窗体打开时，显示现有的收入记录，按日期排序           
            dgvIncome.DataSource = incomeManage.GetIncomeList();
            dgvIncome.Columns[0].Visible = false;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //确认添加一条新记录           
            Income newIncome=new Income();
            newIncome.日期 = DateTime.Parse(dtDate.Text);
            newIncome.金额 = float.Parse(txtMoney.Text);
            newIncome.来源 = txtComefrom.Text;
            if (incomeManage.AddIncome(newIncome))
            {
                txtMoney.Text = "";
                dtDate.Text = DateTime.Now.ToShortTimeString();
                txtComefrom.Text="";
                MessageBox.Show("添加成功", "提示");
                dgvIncome.DataSource = incomeManage.GetIncomeList();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //取消添加的内容
            txtComefrom.Text = "";
            txtMoney.Text = "";
            dtDate.Text = DateTime.Today.ToShortDateString();
        }

        private void msiEdit_Click(object sender, EventArgs e)
        {
            if (dgvIncome.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            int incomeID = Convert.ToInt32(dgvIncome.SelectedRows[0].Cells[0].Value);
            frmEditIncome frmEdit = new frmEditIncome(incomeID);	//将EmployeeID传入Form3中
            frmEdit.ShowDialog();
            dgvIncome.DataSource = incomeManage.GetIncomeList();
        }

        private void msiDelete_Click(object sender, EventArgs e)
        {
            if (dgvIncome.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            int incomeID = Convert.ToInt32(dgvIncome.SelectedRows[0].Cells[0].Value);
            incomeManage.DelIncome(incomeID);
            dgvIncome.DataSource = incomeManage.GetIncomeList();
        }

        

       
    }
}
