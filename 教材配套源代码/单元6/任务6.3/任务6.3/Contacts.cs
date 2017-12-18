using System;
using System.Collections.Generic;
//需要导入的命名空间
using System.Data;
using System.Data.SqlClient;
namespace 任务6._3
{
    public class Person
    {//联系人类
        public int ID { get; set; }//增加一个属性
        public string Name { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Phone { get; set; }
    }

    public static class ContactsBook
    {
        //数据库连接字符串
        const string connstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ContactsDB.mdf;Integrated Security=True";
           
        //读取所有记录缓存在泛型列表中
        public static List<Person> GetAll()
        {
            List<Person> list = new List<Person>();
            string sql = @"SELECT ID, Name, Phone, DayOfBirth FROM Contacts";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //根据记录创建联系人对象
                        Person person = new Person();
                        person.ID = reader.GetInt32(0);
                        person.Name = reader.GetString(1);
                        person.Phone = reader.GetString(2);
                        person.DayOfBirth = reader.GetDateTime(3);
                        list.Add(person); //将联系人对象存入列表
                    }
                }
            }
            return list;
        }

        //更新记录
        public static void Save(Person person)
        {
            string sql = @"UPDATE Contacts SET Name = @Name, Phone = @Phone, DayOfBirth = @DayOfBirth WHERE (ID = @ID)";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = person.Name;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = person.Phone;
                cmd.Parameters.Add("@DayOfBirth", SqlDbType.DateTime).Value = person.DayOfBirth;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = person.ID;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //添加记录
        public static void Add(Person person)
        {
            string sql = @"INSERT INTO Contacts (Name, Phone, DayOfBirth) VALUES (@Name,@Phone,@DayOfBirth)";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = person.Name;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = person.Phone;
                cmd.Parameters.Add("@DayOfBirth", SqlDbType.DateTime).Value = person.DayOfBirth;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //实现删除联系人功能
        public static void Remove(Person person)
        {
            string sql = @"DELETE FROM Contacts WHERE (ID = @ID)";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = person.ID;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //实现清空通讯录功能
        public static void RemoveAll()
        {
            string sql = @"DELETE FROM Contacts";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
