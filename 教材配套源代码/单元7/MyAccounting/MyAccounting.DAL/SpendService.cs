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
    public class SpendService
    {
        public List<Spend> GetSpendList()
        {
            string sqlstr = "select * from Spend order by date DESC ";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<Spend> list = new List<Spend>();
            foreach (DataRow r in dt.Rows)
            {
                Spend spend = new Spend();
                spend.编号 = int.Parse(r["id"].ToString());
                spend.金额 = float.Parse(r["money"].ToString());
                spend.日期 = DateTime.Parse(r["date"].ToString());
                spend.用途 = r["usefor"].ToString();
                list.Add(spend);
            }
            return list;
        }      

        public List<Spend> GetSpendList(DateTime dt1,DateTime dt2)
        {
            string sqlstr = string.Format("select * from Spend  where date Between '{0}' and '{1}' Order by date DESC", dt1.ToShortDateString(), dt2.ToShortDateString());
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<Spend> list = new List<Spend>();
            if (dt != null)
                foreach (DataRow r in dt.Rows)
                {
                    Spend spend = new Spend();
                    spend.编号 = int.Parse(r["id"].ToString());
                    spend.金额 = float.Parse(r["money"].ToString());
                    spend.日期 = DateTime.Parse(r["date"].ToString());
                    spend.用途 = r["usefor"].ToString();
                    list.Add(spend);
                }
                return list;            
        }

        public bool AddSpend(Spend newSpend)
        {
            string sqlStr = "insert into Spend values(@money,@date,@usefor)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@money",newSpend.金额),
                new SqlParameter("@date",newSpend.日期),
                new SqlParameter("@usefor",newSpend.用途)
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public Spend SearchById(int id)
        {
            string sqlstr = string.Format("select * from Spend where id={0}", id);
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            Spend spend = new Spend();
            DataRow r = dt.Rows[0];
            spend.编号 = int.Parse(r["id"].ToString());
            spend.金额 = float.Parse(r["money"].ToString());
            spend.日期 = DateTime.Parse(r["date"].ToString());
            spend.用途 = r["usefor"].ToString();
            return spend;
        }

        public bool SaveEdit(Spend spend) 
        {
            string sqlstr = "update Spend set money=@money,date=@date,usefor=@usefor where id=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@money",spend.金额),
                new SqlParameter("@date",spend.日期),
                new SqlParameter("@usefor",spend.用途),
                new SqlParameter("@id",spend.编号)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }

        public bool DelSpend(int id) 
        {
            string sqlstr = string.Format("delete from Spend where id={0}", id);
            return DBHelper.ExcuteCommand(sqlstr);
        }

    }
}
