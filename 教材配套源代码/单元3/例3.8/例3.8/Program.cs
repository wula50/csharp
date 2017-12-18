using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._8
{
    class Cinema
    {
        private string[] names = new string[5];
        public string this[int n]
        {
            get { return names[n]; }
            set { names[n] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cinema f = new Cinema();
            f[0] = "画皮2";
            f[1] = "致青春";
            int i = 0;
            while (f[i] != null)
            {
                Console.WriteLine(f[i]);
                i++;
            }
            Console.WriteLine(f[0]);
            Console.ReadKey();
        }
    }
}
