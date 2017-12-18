using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._10
{
    public class Car
    {
        public static int count;
        public string id;
        public string type;
        public Car(string id, string type)
        {
            this.id = id;
            this.type = type;
            count++;
        }
        public static void Show()
        {
            Console.WriteLine("当前有车{0}辆", count);
            //Console.WriteLine("汽车类型" + type);
        }
        public void Speak()
        {
            Console.WriteLine("当前有车{0}辆", count);                  
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("渝AVC023", "大众Golf");
            Console.Write("\n访问静态字段来显示车辆数据:");
            Console.WriteLine("当前有车{0}辆", Car.count);
            Car c2 = new Car("桂CWS075", "福特Focus");            
            Console.Write("调用Car类的静态方法来显示车辆数据:");
            Car.Show();
            Console.Write("调用Car类的非静态方法来显示车辆数据:");
            c1.Speak();
            Console.ReadKey();
        }
    }

}
