using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*调用委托*/
namespace 例4._8
{
    delegate int Max(int first, int second);
    class MaxData
    {
        public int IntMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public double DoubleMax(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }

    class Test
    {
        static void Main()
        {
            Max max;
            MaxData md = new MaxData();
            max = new Max(md.IntMax);//实例化委托
            int a = max(2, 3);//调用委托
            Console.WriteLine(a.ToString());

            //max = new Max(md.DoubleMax);//错误代码，返回类型错误
            //double b =max(2.0, 3.0);//重载与委托不匹配
            //Console.WriteLine(b.ToString());
            Console.ReadKey();

        }
    }

}
