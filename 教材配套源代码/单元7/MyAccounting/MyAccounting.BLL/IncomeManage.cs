using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounting.Models;
using MyAccounting.DAL;

namespace MyAccounting.BLL
{
    public class IncomeManage
    {
        IncomeService incomeService = new IncomeService();
        public IList<Income> listIncome;       
        public float totalIncome;       

        //获取收入列表
        public IList<Income> GetIncomeList()
        {
            return incomeService.GetIncomeList();
        }

        public void ViewIncome(DateTime dt1,DateTime dt2)
        {
            totalIncome = 0;
            listIncome=incomeService.GetIncomeList(dt1.Date,dt2.Date);
            for (int i = 0; i < listIncome.Count; i++)
                totalIncome += listIncome[i].金额;
        }       

        //添加收入
        public bool AddIncome(Income newIncome)
        {
            return incomeService.AddIncome(newIncome);
        }

        //删除收入
        public bool DelIncome(int id)
        {
            return incomeService.DelIncome(id);
        }

        //根据编号查找收入记录
        public Income SearchById(int id)
        {
            return incomeService.SearchById(id);
        }

        //修改收入
        public bool SaveEdit(Income income)
        {
            return incomeService.SaveEdit(income);
        }
    }
}
