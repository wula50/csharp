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
    public partial class frmEditSpend : Form
    {
        int ID;
        SpendManage spendManage;
        Spend orgSpend,newSpend;
        public frmEditSpend(int id)
        {           
            InitializeComponent();
            this.ID = id;
           spendManage=new SpendManage();
        }

        private void frmEditSpend_Load(object sender, EventArgs e)
        {
            //显示原来的数据
            orgSpend = new Spend();
            orgSpend = spendManage.SearchById(ID);

            dtDate.Text = orgSpend.日期.ToShortDateString();
            txtMoney.Text = orgSpend.金额.ToString();
            txtComefrom.Text = orgSpend.用途;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            newSpend = new Spend();
            newSpend.编号 = orgSpend.编号;
            newSpend.日期 = DateTime.Parse(dtDate.Text);
            newSpend.金额 = float.Parse(txtMoney.Text);
            newSpend.用途 = txtComefrom.Text;

            //保存修改
            if (spendManage.SaveEdit(newSpend))
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
            dtDate.Text = orgSpend.日期.ToShortDateString();
            txtMoney.Text = orgSpend.金额.ToString();
            txtComefrom.Text = orgSpend.用途;
        }        
    }
}
