using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i=1, m = 1;
            Console.Write("请输入n的值：");
            n = Convert.ToInt16(Console.ReadLine());
            while (i <= n)
            {
                m *= i;
                i++;
            }
            Console.WriteLine("{0}!  是：{1}", n, m);
            Console.ReadKey();
        }
    }
}
