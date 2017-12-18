using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double score; char rank;
            Console.Write("请输入分数：");
            score = Convert.ToDouble(Console.ReadLine());
            switch ((int)score / 10)
            {
                case 10:
                case 9: rank = 'A'; break;
                case 8: rank = 'B'; break;
                case 7: rank = 'C'; break;
                case 6: rank = 'D'; break;
                default: rank = 'E'; break;
            }
            Console.WriteLine("{0}对应的等级是：{1}", score, rank);
            Console.ReadKey();
        }
    }
}
