using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, answer = 0;
            char opt, quit;
            
            do
            {
                Console.WriteLine("请输入算式");
                num1 = Convert.ToDouble(Console.ReadLine());
                opt = Convert.ToChar(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
                switch (opt)
                {
                    case '+': answer = num1 + num2; break;
                    case '-': answer = num1 - num2; break;
                    case '*': answer = num1 * num2; break;
                    case '/': if (num2 == 0)
                            Console.WriteLine("除数不能为0，请重新输入算式！");
                        else
                            answer = num1 / num2;
                        break;
                    default: Console.WriteLine("输入错误！"); break;
                }
                Console.WriteLine("{0}{1}{2}={3}", num1, opt, num2, answer);
                Console.WriteLine("是否还需要继续计算，按任意键继续，按Q键结束！");
                quit = Convert.ToChar(Console.ReadLine());
            } while (quit != 'Q' && quit != 'q');
            Console.WriteLine("计算完毕，再见！");
            Console.ReadKey();
        }
    }
}
