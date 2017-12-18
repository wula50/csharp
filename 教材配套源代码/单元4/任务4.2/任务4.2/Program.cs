using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 任务4._2
{
    enum Direction
    {
        Design, Business, Testing, Game
    }

    struct Student
    {
        public int no;
        public string name;
        public string sex;
        public Direction direction;
        public int credit;
        public bool isGraduate;
        public string Status()
        {
            if (isGraduate)
            {
                return "毕业";
            }
            else
            {
                return "在读";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("请输入第{0}位学生信息", i + 1);
                Console.Write("学号");
                students[i].no = Convert.ToInt32(Console.ReadLine());
                Console.Write("姓名");
                students[i].name = Console.ReadLine();
                Console.Write("性别");
                students[i].sex = Console.ReadLine();
                Console.Write("专业方向");
                students[i].direction = (Direction)int.Parse(Console.ReadLine());
                Console.Write("已获得学分");
                students[i].credit = Convert.ToInt32(Console.ReadLine());
                Console.Write("是否毕业");
                students[i].isGraduate = Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine("=============学员信息表=============");
            Console.WriteLine("学号\t姓名\t性别\t专业方向\t已获得学分\t是否毕业");
            foreach (Student stu in students)
            {
                Console.Write("{0}\t", stu.no);
                Console.Write("{0}\t", stu.name);
                Console.Write("{0}\t", stu.sex);
                Console.Write("{0}\t\t", stu.direction);
                Console.Write("{0}\t\t", stu.credit);
                Console.Write("{0}\t", stu.Status());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
