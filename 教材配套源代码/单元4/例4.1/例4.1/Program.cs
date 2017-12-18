using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[4];
                for (int i = 0; i <= 4; i++)
                {
                    a[i] = i;
                }
                for (int j = 0; j <= 4; j++)
                {
                    System.Console.WriteLine(a[j]);
                }

            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine("数组下标越界");
            }

        }
    }
}
