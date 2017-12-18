using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 例4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue male = new Queue();
            Queue female = new Queue();
            string[] M = new string[] { "Mike", "Jack", "Tom", "Jerry" };
            string[] F = new string[] { "Kate", "Rose", "Wendy" };
            foreach (string item in M)
            {
                male.Enqueue(item);
            }
            foreach (string item in F)
            {
                female.Enqueue(item);
            }
            int i = M.Length;
            int j = F.Length;
            while (i > 0 || j > 0)
            {
                if (male.Count > 0 && female.Count > 0)
                {
                    Console.WriteLine("下一对是： " + male.Dequeue() + "----" + female.Dequeue());
                }
                else if ((male.Count > 0) && (female.Count == 0))
                    Console.WriteLine("等待女舞伴.");
                else if ((female.Count > 0) && (male.Count == 0))
                    Console.WriteLine("等待男舞伴.");
                i--;
                j--;
            }
        }
    }

}
