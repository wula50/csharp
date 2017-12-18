using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._19
{
    interface ICatchMouse
    {
        void Catch();
    }
    class Cat : ICatchMouse
    {
        public string name;
        public Cat(string name)
        {
            this.name = name;
        }
        public void Catch()
        {
            Console.WriteLine("小猫" + name + "在捉老鼠");
        }
    }
    class Owl : ICatchMouse
    {
        public string name;
        public Owl(string name)
        {
            this.name = name;
        }
        public void Catch()
        {
            Console.WriteLine("猫头鹰" + name + "在捉老鼠");
        }
    }
    class Program
    {
        public static void catchTask(ICatchMouse c)
        {
            c.Catch();
        }
        static void Main()
        {           
            catchTask(new Cat("Tom"));
            catchTask(new Cat("Jerry"));
            catchTask(new Owl("Jack"));
            Console.ReadKey();
        }
    } 

}
