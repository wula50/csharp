using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例4._5
{
    struct Ticket
    {
        Name name;
        DateTime datetime;
        string hall;
        string seat;
        string type;
        string remark;
        decimal price;
    }

    enum Name
    { 星球大战, 阿凡达, 美国队长, X战警 }

}
