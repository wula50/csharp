using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*定义事件*/
namespace 例4._10
{
    class EventExample
    {
        public delegate void DelegateMax(int first, int second);
        public event DelegateMax EventMax;
    }

}
