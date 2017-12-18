using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double score; 
            char rank;
            Console.Write("请输入分数：");
            score = Convert.ToDouble(Console.ReadLine());
            if (score >= 90)
                rank = 'A';
            else if (score >= 80 && score < 90)
                rank = 'B';
            else if (score >= 70 && score < 80)
                rank = 'C';
            else if (score >= 60 && score < 70)
                rank = 'D';
            else
                rank = 'E';
            Console.WriteLine("{0}对应的等级是：{1}", score, rank);
            Console.ReadKey();
        }
    }
}
