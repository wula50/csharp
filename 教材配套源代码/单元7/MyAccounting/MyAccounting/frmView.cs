using MyAccounting.BLL;
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
    public partial class frmView : Form
    {
        IncomeManage incomeManage;
        SpendManage spendManage;

        public frmView()
        {
            InitializeComponent();
            incomeManage = new IncomeManage();
            spendManage = new SpendManage();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            dtDate1.Text = DateTime.Now.ToShortTimeString();
            dtDate2.Text = DateTime.Now.ToShortTimeString();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            float l_income=0,l_spend=0,l_diff;
            DateTime dt1, dt2;
            dt1 = DateTime.Parse(dtDate1.Text);
            dt2 = DateTime.Parse(dtDate2.Text);

            lblIncome.Text="";
            lblSpend.Text="";
            lblDiffer.Text="";

            //根据时间段查找收入记录
            incomeManage.ViewIncome(dt1.Date,dt2.Date);
            if (incomeManage.listIncome.Count!=0)
            {
                dgvIncome.DataSource = incomeManage.listIncome;
                dgvIncome.Columns[0].Visible = false;
                l_income=incomeManage.totalIncome;
                lblIncome.Text = l_income.ToString();
            }
            else
                MessageBox.Show("没有找到符合条件的收入记录！");

            //根据时间段查找支出记录
            spendManage.ViewSpend(dt1.Date, dt2.Date);
            if (spendManage.listSpend.Count != 0)
            {
                dgvSpend.DataSource = spendManage.listSpend;
                dgvSpend.Columns[0].Visible = false;
                l_spend = spendManage.totalSpend;
                lblSpend.Text = l_spend.ToString();
            }
            else
                MessageBox.Show("没有找到符合条件的支出记录！");

            l_diff =l_income - l_spend;
            lblDiffer.Text = l_diff.ToString();
        }       
    }
}
