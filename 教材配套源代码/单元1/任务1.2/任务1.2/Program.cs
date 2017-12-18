using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("请输入你的名字：");
            name = Console.ReadLine();
            Console.WriteLine("{0}，欢迎你进入C#世界！", name);
            Console.Read();
        }
    }
}
