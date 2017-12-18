using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounting.Models;
using System.Data;
using System.Data.SqlClient;

namespace MyAccounting.DAL
{
    public class IncomeService
    {
        public List<Income> GetIncomeList()
        {
            string sqlstr = "select * from Income order by date DESC ";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<Income> list = new List<Income>();
            foreach (DataRow r in dt.Rows)
            {
                Income income = new Income();
                income.编号 = int.Parse(r["id"].ToString());
                income.金额 = float.Parse(r["money"].ToString());
                income.日期 = DateTime.Parse(r["date"].ToString());
                income.来源 = r["comefrom"].ToString();                
                list.Add(income);
            }
            return list;
        }

        public List<Income> GetIncomeList(DateTime dt1,DateTime dt2)
        {
            string sqlstr = string.Format("select * from Income  where date Between '{0}' and '{1}' Order by date DESC", dt1.ToShortDateString(), dt2.ToShortDateString());
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<Income> list = new List<Income>();
            if (dt != null)
                foreach (DataRow r in dt.Rows)
                {
                    Income income = new Income();
                    income.编号 = int.Parse(r["id"].ToString());
                    income.金额 = float.Parse(r["money"].ToString());
                    income.日期 = DateTime.Parse(r["date"].ToString());
                    income.来源 = r["comefrom"].ToString();
                    list.Add(income);
                }
                return list;            
        }

        public bool AddIncome(Income newIncome)
        {
            string sqlStr = "insert into Income values(@money,@date,@comefrom)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@money",newIncome.金额),
                new SqlParameter("@date",newIncome.日期),
                new SqlParameter("@comefrom",newIncome.来源)
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public Income SearchById(int id)
        {
            string sqlstr = string.Format("select * from Income where id={0}",id);
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            Income income = new Income();
            DataRow r = dt.Rows[0];
            income.编号 = int.Parse(r["id"].ToString());
            income.金额 = float.Parse(r["money"].ToString());
            income.日期 = DateTime.Parse(r["date"].ToString());
            income.来源 = r["comefrom"].ToString();
            return income;
        }

        public bool SaveEdit(Income income) 
        {
            string sqlstr = "update Income set money=@money,date=@date,comefrom=@comefrom where id=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@money",income.金额),
                new SqlParameter("@date",income.日期),
                new SqlParameter("@comefrom",income.来源),
                new SqlParameter("@id",income.编号)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }

        public bool DelIncome(int id) 
        {
            string sqlstr = string.Format("delete from Income where id={0}",id);
            return DBHelper.ExcuteCommand(sqlstr);
        }

    }
}
