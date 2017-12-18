using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num;
            int[] a = { 12, 33, 0, 45, 6, 19, 28, 37, 46, 11 };
            Console.Write("请输入需要查找的整数：");
            num = Convert.ToInt16(Console.ReadLine());
            while (i < a.Length)
            {
                if (num == a[i])
                {
                    Console.WriteLine("{0}在数组中第{1}个位置！", num, i);
                    break;
                }
                i++;
            }
            if (i == a.Length)
                Console.WriteLine("在数组中没有找到{0}！", num);
            Console.ReadKey();
        }
    }
}
