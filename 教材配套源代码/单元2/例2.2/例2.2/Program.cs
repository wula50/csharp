using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("请输入两个整数");
            Console.Write("a=");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt16(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("两数互换后的结果为");
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.ReadKey();
        }
    }
}
