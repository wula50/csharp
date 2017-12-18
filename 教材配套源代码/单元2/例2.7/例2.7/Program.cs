using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            double pay;
            Console.Write("请输入花费金额：");
            money = Convert.ToDouble(Console.ReadLine());
            switch ((int)money / 1000)
            {
                case 0: pay = money;
                    break;
                case 1: pay = 0.9 * money;
                    Console.WriteLine("有教师证或老人证吗(y/n)");
                    if (Convert.ToChar(Console.ReadLine()) == 'y')
                        pay *= 0.95;
                    break;
                default: pay = 0.85 * money;
                    Console.WriteLine("有教师证或老人证吗(y/n)");
                    if (Convert.ToChar(Console.ReadLine()) == 'y')
                        pay *= 0.95;
                    break;
            }
            Console.WriteLine("消费了{0}元，实际需要支付的费用是：{1:0.00}", money, pay);
            Console.ReadKey();
        }
    }
}
