using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Models
{
    public class Income
    {
        //编号
        public int 编号 { get; set; }

        //金额
        public float 金额 { get; set; }

        //日期
        public DateTime 日期 { get; set; }

        //来源
        public string 来源 { get; set; }

        public Income() { }

        public Income(float money, DateTime date, string comefrom) 
        {
            this.金额= money;
            this.日期 = date;
            this.来源 = comefrom;
        }
    }
}
