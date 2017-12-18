using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double sum = 0, item = 1;
            double pi;
            while (1.0 / item >= 0.000001)
            {
                if (i % 2 != 0)
                    sum += 1.0 / item;
                else
                    sum -= 1.0 / item;
                i++;
                item = 2 * i - 1;
            }
            pi = 4 * sum;
            Console.WriteLine("PI的近似值是：" + pi);
            Console.ReadKey();
        }
    }
}
