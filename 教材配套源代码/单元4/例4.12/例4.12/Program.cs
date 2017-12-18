using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*引发事件*/
namespace 例4._12
{
    class EventExample
    {
        public delegate void DelegateMax(int first, int second);
        public event DelegateMax EventMax;

        public void IntMax(int a, int b)
        {
            Console.WriteLine("判断两个数的大小{0}和{1},较大的是：", a, b);
            EventMax(a, b);
        }
    }

    class Test
    {
        static void Main()
        {

            EventExample ee = new EventExample();
            ee.EventMax += new EventExample.DelegateMax(ee_EventMax);//订阅事件
            ee.IntMax(2, 3);//引发事件
            Console.ReadKey();
        }

        static void ee_EventMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
    }

}
