using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounting.DAL;
using MyAccounting.Models;

namespace MyAccounting.BLL
{
    public class UserManage
    {
        public static bool ValidataUser(User u)
        {
            return UserService.ValidataUser(u);
        }
    }
}
