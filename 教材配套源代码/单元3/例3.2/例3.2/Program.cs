using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._2
{
    class Program
    {
        public void Swap(int a, int b)
        {
            Console.WriteLine("方法内，交换前，a={0}, b={1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("方法内，交换后，a={0}, b={1}", a, b);
        }
        static void Main(string[] args)
        {
            int x = 3, y = 5;
            Program p = new Program();
            Console.WriteLine("调用方法Swap()之前，x={0}, y={1}", x, y);
            p.Swap(x, y);
            Console.WriteLine("调用方法Swap()之后，x={0}, y={1}", x, y);
            Console.ReadKey();
        }
    }
}
