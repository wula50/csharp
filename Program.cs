using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace jiechengDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int s = 1;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    s *= i;
            //}
            //Console.WriteLine("1000的阶乘是{0}",s);
            //Console.ReadKey();

            ArrayList result = new ArrayList();   
        int carryBit = 0;   
  
        result.add(new Integer(1));   
        for (int i = 2; i <= 1000;i++) {   
            for (int j = 0; j < result.Count; j++) {   
                int temp = ((int) result.GetRange(j)).intValue() * i   
                        + carryBit;   
                result.set(in, new Integer(temp % 10));   
                carryBit = temp / 10;   
            }   
            while (carryBit != 0) {   
                result.add(new Integer(carryBit % 10));   
                carryBit = carryBit / 10;   
            }   
        }   
        StringBuffer sb=new StringBuffer(result.size());   
        for(int i=0;i<result.size();i++)   
        {   
            sb.append(result.get(i));   
        }   
        sb=sb.reverse();   
        System.out.println("result="+sb);   
        System.out.println("结果位数"+result.size());  
        }
    }
}
