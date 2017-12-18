using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*追加字符串*/
namespace 例4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder MyAddress = new StringBuilder("重庆市");
            MyAddress.Append("沙坪坝区");
            Console.WriteLine(MyAddress);

            int MyPrice = 25;
            StringBuilder MyStringBuilder = new StringBuilder("邮资一共是 ");
            MyStringBuilder.AppendFormat("{0:C} ", MyPrice);
            Console.WriteLine(MyStringBuilder);
        }
    }

}
