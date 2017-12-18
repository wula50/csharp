using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 36, 3, 0, 45, 12, 56, 17, 31, 9 };
            int i, j;
            int temp;
            Console.WriteLine("未排序前的数组元素为");
            for (i = 0; i < a.Length; i++)
                Console.Write("{0}  ", a[i]);
            Console.WriteLine();
            for (i = 1; i <= a.Length - 1; i++)
                for (j = 0; j < a.Length - i; j++)
                {
                    if (a[j] > a[j + 1])
                    { temp = a[j]; a[j] = a[j + 1]; a[j + 1] = temp; }
                }
            Console.WriteLine("排序后的数组元素为");
            for (i = 0; i < a.Length; i++)
                Console.Write("{0}  ", a[i]);
            Console.ReadKey();
        }
    }
}
