using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._6
{
    class Program
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z) 		//参数个数不同
        {
            return x + y + z;
        }
        public float Add(float x, float y)		// 参数类型不同
        {
            return x + y;
        }
        public double Add(double x, double y) 	// 参数类型不同
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("两个整数相加" + p.Add(3, 5));
            Console.WriteLine("三个整数相加" + p.Add(3, 5, 7));
            Console.WriteLine("两个单精度小数相加" + p.Add(3.2f, 5.4f)); //调用第3个Add()方法
            Console.WriteLine("两个双精度小数相加" + p.Add(3.2, 5.4)); //调用第4个Add()方法
            Console.ReadKey();
        }

    }
}
