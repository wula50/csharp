using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 例4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable(3);
            h.Add(1, "0001");
            h.Add(2, "洗发水");
            h.Add("decimal", 15);

            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine("{0}    {1}", item.Key, item.Value);
            }

            h.Remove("decimal");
            Console.WriteLine("\n删除后的哈希表");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine("{0}    {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }

}
