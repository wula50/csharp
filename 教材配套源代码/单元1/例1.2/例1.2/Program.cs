using System;

namespace 例1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输出后不换行");//输出字符串后不换行
            Console.WriteLine("输出后换行");//输出后换一行
            Console.WriteLine(1234);//参数是整数，输出该整数的字符串表示
            //参数是DateTime结构类型的数据，输出该结构体变量的字符串表示
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}
