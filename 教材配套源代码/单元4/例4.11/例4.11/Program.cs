using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*订阅事件*/
namespace 例4._11
{
    class EventExample
    {
        public delegate void DelegateMax(int first, int second);
        public event DelegateMax EventMax;
    }

    class Test
    {
        static void Main()
        {

            EventExample ee = new EventExample();
            ee.EventMax += new EventExample.DelegateMax(ee_EventMax);//订阅事件
        }
    }

}
