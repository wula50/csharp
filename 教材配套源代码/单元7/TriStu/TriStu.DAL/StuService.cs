using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriStu.Models;

namespace TriStu.DAL
{
    public class StuService
    {
        public List<Student> GetStudentList()
        {
            string sqlstr = "select * from T_Stu";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<Student> list = new List<Student>();
            foreach (DataRow r in dt.Rows)
            {
                Student stu = new Student();
                stu.ID = int.Parse(r["ID"].ToString());
                stu.Name = r["name"].ToString();
                stu.Age = int.Parse(r["age"].ToString()); ;
                list.Add(stu);
            }
            return list;
        }
        public bool AddStudent(Student newStu)
        {
            string sqlStr = "insert into T_Stu values(@ID,@name,@age)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID",newStu.ID),
                new SqlParameter("@name",newStu.Name),
                new SqlParameter("@age",newStu.Age)
            };
            return DBHelper.ExcuteCommand(sqlStr, param);           
        }
        public bool UpdateStudent(Student stu) 
        {
            string sqlstr = "update T_Stu set name=@name,age=@age where ID=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@name",stu.Name),
                new SqlParameter("@age",stu.Age),
                new SqlParameter("@ID",stu.ID)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }

        public bool DelStudent(int id)
        {
            List<String> strSqls = new List<string>();//创建集合对象
            List<SqlParameter[]> param = new List<SqlParameter[]>();
            string strDelete1 = "delete From T_Stu where ID = @id";//定义删除表T_Stu的SQL语句
            strSqls.Add(strDelete1);//将SQL语句添加到集合中
            SqlParameter[] param1 = new SqlParameter[]
            {
                new SqlParameter("@ID",id)
            };
            param.Add(param1);
            string strDelete2 = "delete From T_SC where Sno = @sno";//定义删除表T_SC的SQL语句
            strSqls.Add(strDelete2);//将SQL语句添加到集合中
            SqlParameter[] param2 = new SqlParameter[]
            {
                new SqlParameter("@sno",id)
            };
            param.Add(param2);
            return DBHelper.ExcuteCommand(strSqls, param);
        }
    }
}
