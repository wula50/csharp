using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal interest = 0.0035m;
            decimal money, principal;
            int t;
            Console.WriteLine("输入存款金额");
            principal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("输入存款期限(以月为单位):");
            t = Convert.ToInt16(Console.ReadLine());
            money = principal + principal * interest * t * 1 / 12;
            Console.WriteLine("{0}元存{1}个月，本息合计金额为：{2:f}元 ", principal, t, money);
            Console.ReadKey();
        }
    }
}
