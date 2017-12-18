using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, sum = 0;
            Console.Write("请输入n的值");
            n = Convert.ToInt16(Console.ReadLine());
      loop: sum += i;
            i++;
            if (i <= n)
                goto loop;
            Console.WriteLine("1+2+...+{0}的和为{1}", n, sum);
            Console.ReadKey();
        }
    }
}
