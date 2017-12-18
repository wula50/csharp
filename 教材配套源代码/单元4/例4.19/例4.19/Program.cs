using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 例4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Score s = new Score();
            s.AddMark();
            s.Del();
            Console.WriteLine("平均分是{0}", s.Average());
            Console.ReadKey();
        }
    }

    class Score
    {
        ArrayList al = new ArrayList();
        public void AddMark()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("请输入评为分数，以-1结束");
                i = int.Parse(Console.ReadLine());
                if (i != -1) al.Add(i);
                else break;
            }
        }

        public void Del()
        {
            if (al.Count > 2)
            {
                al.Sort();
                al.RemoveAt(0);
                al.RemoveAt(al.Count - 1);
            }
        }

        public double Average()
        {
            double sum = 0;
            foreach (int i in al) { sum += i; }
            return sum / al.Count;
        }
    }

}
