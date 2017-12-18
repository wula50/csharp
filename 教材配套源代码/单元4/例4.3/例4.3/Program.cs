using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*自定义异常，以实现信用卡申请中出现的学历导致审核问题*/
namespace 例4._3
{
    class LegalEducationException : System.Exception
    {
        public LegalEducationException(string edu)
        {
            System.Console.WriteLine("学历" + "'" + edu + "'" + "不符合岗位要求");
        }
    }
    class Program
    {
        public static void EducationCheck(string edu)
        {
            if (!edu.Equals("大专生"))
            {
                throw new LegalEducationException(edu);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("请输入您的学历：");
                string edu = System.Console.ReadLine();
                EducationCheck(edu);
            }
            catch (LegalEducationException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }

}
