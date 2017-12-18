using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 例4._21
{
    class Program
    {
        static string Convert(int i, int j)
        {
            if (i < 2 || j > 16) { return "只能将十进制转化为二到十六进制"; }

            Stack stack = new Stack();

            do
            {
                int k = i % j;
                char c = (k < 10) ? (char)(k + 48) : (char)(k + 55);
                stack.Push(c);
            } while ((i = i / j) != 0);

            string s = "";
            while (stack.Count > 0)
            {
                s += stack.Pop().ToString();
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个十进制数：");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入要转换的进制：");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert(i, j));
            Console.ReadKey();
        }
    }

}
