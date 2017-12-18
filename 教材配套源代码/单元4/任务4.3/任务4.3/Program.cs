using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务4._3
{
    class Robber
    {
        public void runaway()
        {
            Console.WriteLine("逃跑");
        }
    }
    class Police
    {
        public void chase()
        {
            Console.WriteLine("哪里跑");
        }
    }
    class Human
    {
        public delegate void humandelegate();
        public event humandelegate humanevent;
        public void Help() { humanevent(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            Robber r1 = new Robber();
            Robber r2 = new Robber();
            Police p1 = new Police();
            Police p2 = new Police();
            h.humanevent += new Human.humandelegate(h_humanevent);
            h.humanevent += r1.runaway;
            h.humanevent += r2.runaway;
            h.humanevent += p1.chase;
            h.humanevent += p2.chase;
            //h.Help();
            Console.ReadKey();
        }

        static void h_humanevent()
        {
            Console.WriteLine("救命啊");
        }
    }

}
