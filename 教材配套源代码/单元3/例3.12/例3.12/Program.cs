using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._12
{
    class Animal
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string toString()
        {
            return "这是一个动物类";
        }
        public void sound()
        {
            Console.WriteLine("动物声音");
        }
    }
    class Cat : Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string toString()
        {
            return "猫猫的名字是" + name + "，属于" + Type + ", 它会";
        }
        public void sound()
        {
            Console.WriteLine("喵喵叫");
        }
    }
    class Dog : Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public new string toString()
        {
            return "狗狗的名字是" + name + "，属于" + Type + ", 它会";
        }
        public new void sound()
        {
            Console.WriteLine("汪汪叫");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Type = "哺乳类";
            d.Name = "Tom";
            Console.Write(d.toString());
            d.sound();
            Cat c = new Cat();
            c.Type = "哺乳类";
            c.Name = "Ketty";
            Console.Write(c.toString());
            c.sound();
            Animal d1 = new Dog();
            //d1.Name = "Jack"; //对象d1不具有Name属性，此句不能通过编译
            Console.ReadKey();
        }
    }

}
