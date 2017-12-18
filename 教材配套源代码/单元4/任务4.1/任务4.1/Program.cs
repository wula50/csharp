using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            try
            {
                Console.WriteLine("请输入第一个操作数;");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个操作数:");
                num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("请输入运算符（+、-、*、/）:");
                string operater = Console.ReadLine();

                if (operater == "+")
                {
                    flag = 0;
                }
                if (operater == "-")
                {

                    flag = 1;
                }
                if (operater == "*")
                {

                    flag = 2;
                }
                if (operater == "/")
                {
                    flag = 3;
                }

                switch (flag)
                {
                    case 0:
                        result = num1 + num2;
                        break;
                    case 1:
                        result = num1 - num2;
                        break;
                    case 2:
                        result = num1 * num2;
                        break;
                    case 3:
                        result = num1 / num2;
                        break;
                }

                Console.WriteLine(num1 + operater + num2 + "=" + result);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }	

}
