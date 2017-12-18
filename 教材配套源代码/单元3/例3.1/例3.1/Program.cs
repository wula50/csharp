using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._1
{
    class Car
    {
        public string type;  	//类型 
        public float weight;	//重量   
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.type = "大众Golf";
            c1.weight = 1.295f;
            Car c2 = new Car();
            c2.type = "福特Focus";
            c2.weight = 1.308f;
            Console.WriteLine("我是{0}，重量为{1}吨", c1.type, c1.weight);
            Console.WriteLine("我是{0}，重量为{1}吨", c2.type, c2.weight);
            Console.ReadKey();
        }
    }
}
