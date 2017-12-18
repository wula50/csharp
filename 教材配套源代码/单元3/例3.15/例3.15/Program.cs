using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例3._15
{
    abstract class Animal
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void eat();
    }
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void eat()
        {
            Console.WriteLine("小猫" + this.name + "正在吃小鱼");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void eat()
        {
            Console.WriteLine("小狗" + this.name + "正在啃骨头");
        }
    }
    class Program
    {
        static void Main()
        {
            Cat cat = new Cat("Tom", 3);
            Dog dog = new Dog("Jack", 4);
            cat.eat();
            dog.eat();
            Console.ReadKey();
        }
    }  

}
