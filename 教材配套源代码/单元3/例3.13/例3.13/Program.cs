using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入正方形的长：");
            Square s = new Square(double.Parse(Console.ReadLine()));
            Console.WriteLine("正方形的面积为：{0}", s.Area());
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        protected double length;
        private double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
    }
    class Square : Rectangle
    {
        public Square(double l) : base(l, 0) { }
        public double Area()
        {
            return length * length;
        }
    }

}
