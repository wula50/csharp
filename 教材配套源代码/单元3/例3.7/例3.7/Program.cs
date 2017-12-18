using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._7
{
    public class Car
    {
        private string type;
        public string Type
        {
            get { return type; ; }
            set { type = value; }
        }
        private float weight;
        public float Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public Car() { }
        public Car(string t, float w)
        {
            this.Type = t;
            this.Weight = w;
        }
        public void ShowInfo()
        {
            Console.WriteLine("我是{0}，重量为{1}吨", type, weight);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("大众Golf", 1.295f);
            Car c2 = new Car();
            c2.Type = "福特Focus";
            c2.Weight = 1.308f;           
            c1.ShowInfo();
            c2.ShowInfo();
            Console.WriteLine("修改" + c1.Type + "的重量，请输入新的重量");
            c1.Weight = float.Parse(Console.ReadLine());
            Console.WriteLine(c1.Type + "的新重量为{0}", c1.Weight);
            Console.WriteLine("修改" + c2.Type + "的重量，请输入新的重量");
            c1.Weight = float.Parse(Console.ReadLine());
            Console.WriteLine(c2.Type + "的新重量为{0}", c2.Weight);
            Console.ReadKey();
        }
    }
}
