using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounting.Models;
using MyAccounting.DAL;

namespace MyAccounting.BLL
{
    public class SpendManage
    {
        SpendService spendService = new SpendService();
        public IList<Spend> listSpend;
        public float totalSpend;

        public void ViewSpend(DateTime dt1, DateTime dt2)
        {
            totalSpend = 0;
            listSpend = spendService.GetSpendList(dt1.Date, dt2.Date);
            for (int i = 0; i < listSpend.Count; i++)
                totalSpend += listSpend[i].金额;
        }

        //获取支出列表
        public IList<Spend> GetSpendList()
        {
            return spendService.GetSpendList();
        }

        //添加支出
        public bool AddSpend(Spend newSpend)
        {
            return spendService.AddSpend(newSpend);
        }

        //删除支出
        public bool DelSpend(int id)
        {
            return spendService.DelSpend(id);
        }

        //根据编号查找支出记录
        public Spend SearchById(int id)
        {
            return spendService.SearchById(id);
        }

        //修改支出
        public bool SaveEdit(Spend spend)
        {
            return spendService.SaveEdit(spend);
        }
    }
}
