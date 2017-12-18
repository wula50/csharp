using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Regex类的使用*/
namespace 例4._18
{
    public static class RegLibrary
    {
        public static bool IsNumber(string v)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(v, @"^(-?\d+)(\.\d+)?$") ? true : false;
        }
    }
    class Test
    {
        static void Main()
        {

            Console.WriteLine("请输入金额");
            string s = Console.ReadLine();
            if (RegLibrary.IsNumber(s))
            {
                Console.WriteLine("输入格式正确");
            }
            else
            {
                Console.WriteLine("输入格式不正确");
            }
            Console.ReadKey();
        }
    }

}
