﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyAccounting.DAL
{
    class DBHelper
    {
        //定义数据库连接字符串
        public static string connString =@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True;Connect Timeout=30";
        
         //定义数据库连接对象
        public static SqlConnection conn = new SqlConnection(connString);

        //获取数据的方法，返回DataTable对象，参数为一个select语句
        public static DataTable GetDataTable(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter dapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dapt.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        //获取数据的重载方法，返回DataTable对象，参数为一个参数化的select语句和参数对象数组
        public static DataTable GetDataTable(string sqlStr, SqlParameter[] param)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddRange(param);
                SqlDataAdapter dapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dapt.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        //执行更新的方法，返回一个布尔值，参数为一个insert|update|delete语句
        public static bool ExcuteCommand(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //执行更新的重载方法，返回一个布尔值，参数为一个参数化的insert|update|delete语句和参数对象数组
        public static bool ExcuteCommand(string sqlStr, SqlParameter[] param)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}