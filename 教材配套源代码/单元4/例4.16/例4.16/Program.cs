using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*替换字符串*/
namespace 例4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder MyText = new StringBuilder("2016年的目标是要做成2016件好事");
            MyText.Replace("2016", "2017");
            Console.WriteLine(MyText);

        }
    }

}
