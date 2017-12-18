using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._11
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temp)
        {
            double celsius = Double.Parse(temp);
            //摄氏度到华氏度的转换
            double fahrenheit = (celsius * 9.0 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double fahrenheit = Double.Parse(temperatureFahrenheit);
            //华氏度到摄氏度的转换
            double celsius = (fahrenheit - 32.0) * 5 / 9;
            return celsius;
        }
    }

    class Test
    {
        static void Main()
        {
            Console.WriteLine("请选择转换的方式");
            Console.WriteLine("1. 摄氏度转换为华氏度.");
            Console.WriteLine("2. 华氏度转换为摄氏度.");           
            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("请输入摄氏温度: ");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("对应的华氏度为: {0:0.00}", F);
                    break;

                case "2":
                    Console.Write("请输入华氏温度 ");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("对应的摄氏度为: {0:0.00}", C);
                    break;

                default:
                    Console.WriteLine("请选择一种转换方式.");
                    break;
            }
            Console.WriteLine("按任意键退出.");
            Console.ReadKey();
        }
    }

}
