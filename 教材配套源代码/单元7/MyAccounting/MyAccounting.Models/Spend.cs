using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Models
{
    public class Spend
    {
        //编号
        public int 编号 { get; set; }
  
       //金额
        public float 金额 { get; set; }

        //日期
        public DateTime 日期 { get; set; }

        //用处
        public string 用途 { get; set; }
        
        public Spend() { }

        public Spend(float money, DateTime date, string usefor, string note) 
        {
            this.金额= money;
            this.日期 = date;
            this.用途 = usefor;           
        }
    }
}
