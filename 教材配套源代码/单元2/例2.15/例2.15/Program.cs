using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int sum = 0;
            Console.Write("请输入n的值：");
            n = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    continue;
                sum += i;
            }
            Console.WriteLine("1到{0}之间的偶数之和为{1}", n, sum);
            Console.ReadKey();
        }
    }
}
