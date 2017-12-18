using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例4._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> s = new Stack<char>(50);
            Queue<char> q = new Queue<char>(50);
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; ++i)
            {
                s.Push(str[i]);
                q.Enqueue(str[i]);
            }
            while (s.Count != 0 && q.Count != 0)
            { if (s.Pop() != q.Dequeue()) break; }
            if (s.Count != 0 || q.Count != 0)
            { Console.WriteLine("这不是回文！"); }
            else
            { Console.WriteLine("这是回文！"); }
            Console.ReadKey();
        }
    }

}
