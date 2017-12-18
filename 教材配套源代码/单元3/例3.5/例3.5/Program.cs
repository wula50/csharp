using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._5
{
    class Car
    {
        public string type;
        public float weight;
        public Car() { }   //显式声明默认构造方法
        public Car(string type, float weight)
        {
            this.type = type;
            this.weight = weight;
        }
        public void ShowInfo()
        {
            Console.WriteLine("我是{0}，重量为{1}吨", type, weight);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("大众Golf", 1.295f);
            Car c2 = new Car();
            c2.type = "福特Focus";
            c2.weight = 1.308f;         
            c1.ShowInfo();
            c2.ShowInfo();
            Console.ReadKey();
        }
    }

}
