using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, comdiv, commul, max, min;
            Console.WriteLine("输入两个数");
            n = Convert.ToInt16(Console.ReadLine());
            m = Convert.ToInt16(Console.ReadLine());
            if (n < m)
            {
                min = n;
                max = m;
            }
            else
            {
                min = m;
                max = n;
            }
            comdiv = min;
            do
            {
                if (max % min == 0)
                    break;
                if (max % comdiv == 0 && min % comdiv == 0)
                    break;
                comdiv--;
            } while (comdiv > 1);
            commul = max - 1;
            do
            {
                commul++;
            } while (commul % max != 0 || commul % min != 0);
            Console.WriteLine("最大公约数为：" + comdiv);
            Console.WriteLine("最小公倍数为：" + commul);
            Console.ReadKey();
        }
    }
}
