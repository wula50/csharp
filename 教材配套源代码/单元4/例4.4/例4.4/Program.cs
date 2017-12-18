using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*使用枚举来存储太阳、地球和月亮的半径，并计算它们的体积*/
namespace 例4._4
{
    public enum SolarSystem
    {
        Sun = 696300, Earth = 6380, Moon = 1740
    }
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem sun = SolarSystem.Sun;
            SolarSystem earth = SolarSystem.Earth;
            SolarSystem moon = SolarSystem.Moon;
            Console.WriteLine("太阳体积为：" + 4 / 3 * 3.14 * Math.Pow((int)sun, 3));
            Console.WriteLine("地球体积为：" + 4 / 3 * 3.14 * Math.Pow((int)earth, 3));
            Console.WriteLine("月球体积为：" + 4 / 3 * 3.14 * Math.Pow((int)moon, 3));
        }
    }

}
