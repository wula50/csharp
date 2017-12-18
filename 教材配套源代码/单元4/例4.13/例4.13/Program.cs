using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*格式化字符串*/
namespace 例4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "0001";
            string name = "X洗发水";
            decimal inprice = 10M;
            float profit = 0.5f;
            decimal outprice = 15M;

            Console.WriteLine("{0,30}", "商品表");
            Console.WriteLine();
            Console.Write("货号");
            Console.Write("{0,10}", "商品名称");
            Console.Write("{0,10}", "进货价（元）");
            Console.Write("{0,8}", "利润率");
            Console.WriteLine("{0,10}", "售价（元）");
            string s = string.Format("{0,-10}{1,-10}{2,-15:￥0.0}{3,-12:0.00%}{4,-10:￥0.0}", id, name, inprice, profit, outprice);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }

}
