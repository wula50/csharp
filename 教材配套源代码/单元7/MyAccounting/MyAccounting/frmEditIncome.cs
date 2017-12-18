using MyAccounting.BLL;
using MyAccounting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class frmEditIncome : Form
    {
        int ID;
        IncomeManage incomeManage;
        Income orgIncome,newIncome;
        public frmEditIncome(int id)
        {           
            InitializeComponent();
            this.ID = id;
            incomeManage=new IncomeManage();
        }

        private void frmEditIncome_Load(object sender, EventArgs e)
        {
            //显示原来的数据
            orgIncome = new Income();
            orgIncome = incomeManage.SearchById(ID);

            dtDate.Text = orgIncome.日期.ToShortDateString();
            txtMoney.Text = orgIncome.金额.ToString();
            txtComefrom.Text = orgIncome.来源;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            newIncome = new Income();
            newIncome.编号 = orgIncome.编号;
            newIncome.日期 = DateTime.Parse(dtDate.Text);
            newIncome.金额 = float.Parse(txtMoney.Text);
            newIncome.来源 = txtComefrom.Text;

            //保存修改
            if (incomeManage.SaveEdit(newIncome))
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
                MessageBox.Show("修改失败");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //恢复原数据
            dtDate.Text=orgIncome.日期.ToShortDateString();
            txtMoney.Text=orgIncome.金额.ToString();
            txtComefrom.Text = orgIncome.来源; ;
        }

        
    }
}
