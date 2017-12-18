using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例4._23
{
    public class MyList<T>
    {
        private static int objCount = 0;
        public MyList() { objCount++; }

        public int Count
        { get { return objCount; } }
    }

    class SampleClass { }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            MyList<int> myIntList2 = new MyList<int>();
            MyList<double> myDoubleList = new MyList<double>();
            MyList<SampleClass> mySampleList = new MyList<SampleClass>();
            Console.WriteLine(myIntList.Count);//输出2
            Console.WriteLine(myIntList2.Count);//输出2
            Console.WriteLine(myDoubleList.Count);//输出1
            Console.WriteLine(mySampleList.Count);//输出1
            Console.WriteLine(new MyList<SampleClass>().Count);//输出2
            Console.ReadLine();
        }
    }

}
