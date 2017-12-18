using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b;           
            Console.WriteLine("请输入一个字母：");           
            a = Convert.ToChar(Console.ReadLine());
            b = (a >= 'A' && a <= 'Z') ? Convert.ToChar(a + 32) : ((a >= 'a' && a <= 'z') ? Convert.ToChar(a - 32) : a);
            Console.WriteLine("字母经过大小写转好后为：" + b);
            Console.ReadKey();
        }
    }
}
