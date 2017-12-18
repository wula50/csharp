using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._4
{
    class Car
    {
        public string type;
        public float weight;
        public Car(string type, float weight) //自定义的构造方法
        {
            this.type = type; //等号右边的type为形参type，this.type中的type为字段
            this.weight = weight;
        }
        public void ShowInfo()
        {
            Console.WriteLine("我是{0}，重量为{1}吨", type, weight); // type和weight为字段
        }
    }
     class Program
     {
         static void Main(string[] args)
         {
             string t;
             float w;
             Car c1 = new Car("大众Golf",1.295f);
		     Console.Write("输入汽车型号：");
             t= Console.ReadLine();
             Console.Write("输入汽车重量（吨）：");
             w= float.Parse( Console.ReadLine());
             Car c2= new Car(t, w);
             c1.ShowInfo();
             c2.ShowInfo();
             Console.ReadKey();
          }
     }

}
