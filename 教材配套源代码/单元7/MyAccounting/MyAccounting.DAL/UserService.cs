using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyAccounting.Models;
using System.Data;

namespace MyAccounting.DAL
{
    public class UserService
    {
        //验证用户账户密码
        public static bool ValidataUser(User u)
        {
            string sqlstr = "select id from [User] where (id = @id) and (pwd = @pwd)";
            SqlParameter[] param=new SqlParameter[]
            {
                new SqlParameter("@id",u.ID),
                new SqlParameter("@pwd",u.Pwd)
            };             
            DataTable dt = DBHelper.GetDataTable(sqlstr,param);
            if (dt.Rows.Count != 0)
                return true;
            else
                return false;                    
        }
    }
}
