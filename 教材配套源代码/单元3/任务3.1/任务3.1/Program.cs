using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务3._1
{
    class Rectangle
    {
        double length;
        double width;
        public Rectangle(double length)
        {
            this.length = length;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            if (width > 0)
                return length * width;
            else
                return length * length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入正方形的边长：");
            double l = double.Parse(Console.ReadLine());
            Rectangle r1 = new Rectangle(l);
            Console.WriteLine("正方形面积为：" + r1.Area());
            Console.WriteLine("请输入长方形的长：");
            l = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入长方形的宽：");
            double w = double.Parse(Console.ReadLine());
            Rectangle r2 = new Rectangle(l, w);
            Console.WriteLine("长方形面积为：" + r2.Area());
            Console.ReadKey();
        }
    }

}
