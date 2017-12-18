using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("请输入x：");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 1)
                y = x - 1;
            else if (x >= 1 && x <= 3)
                y = x;
            else
                y = 2 * x;
            Console.WriteLine("y的值是：{0}", y);
            Console.ReadKey();
        }
    }
}
