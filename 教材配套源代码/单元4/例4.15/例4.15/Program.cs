using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*插入字符串*/
namespace 例4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder MyAddress = new StringBuilder("北京");
            MyAddress.Insert(0, "中国");
            Console.WriteLine(MyAddress);

        }
    }

}
