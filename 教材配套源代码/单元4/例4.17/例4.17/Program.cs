using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例4._17
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("长日期时间：{0,10:f}", dt);
            Console.WriteLine("年：{0,10:yyyy}", dt);
            Console.WriteLine("月：{0,10:MM}", dt);
            Console.WriteLine("日：{0,10:dd}", dt);
            Console.WriteLine("时：{0,10:hh}", dt);
            Console.WriteLine("分：{0,10:mm}", dt);
            Console.WriteLine("秒：{0,10:ss}", dt);
            Console.WriteLine("星期：{0,5:dddd}", dt);
            Console.ReadKey();
        }
    }
}


