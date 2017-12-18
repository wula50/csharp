using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            Console.WriteLine(Add(a, b));
            Console.ReadKey();
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
