using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriStu.Models
{
    public class Student
    {
         //学号
        public int ID { get; set; }

        //姓名
        public string Name { get; set; }

        //年龄
        public int Age { get;set; }

        public Student() { }

        public Student(int ID, string name,int age) 
        {
            this.ID = ID;
            this.Name = name;
            this.Age = age;
        }    
    }
}
