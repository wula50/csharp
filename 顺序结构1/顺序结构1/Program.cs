using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序结构1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region   ///顺序结构练习：
            ///1．	设圆半径r=1.5，圆柱高h=3，求圆周长，圆面积，圆球表面积，圆球体积，圆柱体积。
            ///用scanf输入数据，输出计算结果；输出时要求有文字说明，取小数点后2位数字，
            ///请编写程序。
            ///
            //float h, r, l, s, sq, vq, vz;
            //float pi = 3.141526f;
            //Console.WriteLine("请输入圆半径r,圆柱高h：");
            //r = float.Parse(Console.ReadLine());
            //h = float.Parse(Console.ReadLine());

            //l = 2 * pi * r;
            //s = r * r * pi;
            //sq = 4 * pi * r * r;
            //vq = (3.0f / 4.0f) * pi *(float) Math.Pow(r,3);
            //vz = pi * r * r * h;
            //Console.WriteLine("圆周长为:        l={0}\n", l);
            //Console.WriteLine("圆面积为:        s={0}\n", s);
            //Console.WriteLine("圆球表面积为:    sq={0}f\n", sq);
            //Console.WriteLine("圆球体积为:      v={0}\n", vq);
            //Console.WriteLine("圆柱体积为:      vz={0}\n", vz);
            //Console.ReadKey();
            #endregion

            #region  /// Console.Read()识别的是一个字符、换行和回车，但不处理换行和回车，所以代码最后一句
            /// Console.ReadLine();读取的是回车，执行的感觉就是跳过了
            /// 问题代码1
            //int r, h;
            //Console.WriteLine("请输入身高r：");
            //r = Console.Read();
            //Console.WriteLine("请输入体重：");
            //h = Console.Read();
            //Console.ReadLine();

            ///相关例子1
            //int maya = 100;
            //while (maya.ToString() != "exit")
            //{
            //    Console.Write("{0}\t", maya);
            //    maya = Console.Read();
            //}

            ///相关例子2           
            //char getchar = 'y';
            //while (getchar != 'n')
            //{
            //    Console.WriteLine("not n");
            //    getchar = (char)Console.Read();
            //    Console.WriteLine("getchar is {0}", getchar);
            //}

            // 运行结果
            //not n
            //getchar is
            //not n
            //getchar is

            //not n
            //n
            //getchar is n
            #endregion

            #region 1．	下面程序的功能是求3个整数中的最小数，,将程序补充完整
            //int x, y, z, min;
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());
            //z = int.Parse(Console.ReadLine());

            //if (x < y) min = x;
            //else min = y;
            //if (z < min) min = z;
            //Console.WriteLine("min={0}", min);
            #endregion

            #region 读出程序的执行结果1
            //int a = 1, b = 3, c = 5, d = 4, x;
            //if (a < b)
            //    if (c < d) x = 1;
            //    else
            //        if (a < c)
            //            if (b < d) x = 2;
            //            else x = 3;
            //        else x = 6;
            //else x = 7;
            //Console.WriteLine("x={0}", x);
            #endregion
            
            
            Console.ReadKey();


        }
    }
}
            





