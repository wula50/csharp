using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Models
{
    public class User
    {
         //账户
        public string ID { get; set; }

        //密码
        public string Pwd { get; set; }


        public User() { }

        public User(string userID, string userPwd) 
        {
            this.ID = userID;
            this.Pwd = userPwd;
        }    
    }
}
