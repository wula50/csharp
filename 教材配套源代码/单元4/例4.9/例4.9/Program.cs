using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*多播委托*/
namespace 例4._9
{
    delegate void Del(string s);

    class TestClass
    {
        static void Hello(string s)
        { System.Console.WriteLine("  Hello, {0}!", s); }

        static void Goodbye(string s)
        {
            System.Console.WriteLine("  Goodbye, {0}!", s);
        }

        static void Main()
        {
            Del a, b, c, d;

            a = Hello;
            b = Goodbye;
            c = a + b;
            d = c - a;

            System.Console.WriteLine("Invoking delegate a:");
            a("A");
            System.Console.WriteLine("Invoking delegate b:");
            b("B");
            System.Console.WriteLine("Invoking delegate c:");
            c("C");
            System.Console.WriteLine("Invoking delegate d:");
            d("D");
            Console.ReadKey();
        }
    }

}
