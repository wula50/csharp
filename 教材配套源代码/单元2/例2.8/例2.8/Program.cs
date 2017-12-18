using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i, m = 1;
            Console.Write("请输入n的值：");
            n = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= n; i++)
                m *= i;
            Console.WriteLine("{0}!  是：{1}", n, m);
            Console.ReadKey();
        }
    }
}
