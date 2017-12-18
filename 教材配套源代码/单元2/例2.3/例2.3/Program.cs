using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            Console.WriteLine("请输入三个整数");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            if (a > b)
                max = a;
            else
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine("这三个数中{0}最大", max);
            Console.ReadKey();
        }
    }
}
