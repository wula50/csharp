using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*实例化委托*/
namespace 例4._7
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
           

        }
    }

}
