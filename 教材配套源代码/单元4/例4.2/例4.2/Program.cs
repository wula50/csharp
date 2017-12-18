using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*try-catch-finally的使用*/
namespace 例4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
            }
            catch (FormatException) // 如果发生输入异常
            {
                Console.WriteLine("提示：输入格式错误！");
            }
            catch (DivideByZeroException) // 如果发生除数为0的异常
            {
                Console.WriteLine("提示：除数不能为0！");
            }
            catch (Exception ex) // 如果发生其他异常
            {
                Console.WriteLine(ex.Message);
            }
            finally  // 无论是否发生异常，都正常结束
            {
                Console.WriteLine("感谢使用本软件!");
            }

        }
    }
}