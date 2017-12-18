using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriStu.DAL;
using TriStu.Models;

namespace TriStu.BLL
{
    public class StuManager
    {
        StuService stu = new StuService();
        public List<Student> GetStudentList()
        {            
            return stu.GetStudentList();
        }

        public bool AddStudent(Student newStu)
        {
            return stu.AddStudent(newStu);
        }

        public bool UpdateStudent(Student s)
        {
            return stu.UpdateStudent(s);
        }

        public bool DelStudent(int id)
        {
            return stu.DelStudent(id);
        }
    }
}
