using System;
using System.Collections.Generic;
using System.IO;

namespace 任务6._1
{
    //联系人类
    public class Person
    {
        public string Name { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Phone { get; set; }
    }

    public static class ContactsBook
    {
        const string DATA_FILE = "contacts.dat";//文件位置
        const char EOF = '\0';//定义文件结束的标志字符
        static List<Person> _contacts;//存储联系人的列表

        static ContactsBook()//静态构造
        { _contacts = ContactsBook.Open(); }

        //对外公开Contacts属性
        public static List<Person> Contacts
        { get { return _contacts; } }

        //私有静态方法，读取文件数据到泛型列表中
        private static List<Person> Open()
        {
            List<Person> list = new List<Person>();

            if (!File.Exists(DATA_FILE)) return list;

            using (BinaryReader br = new BinaryReader(File.OpenRead(DATA_FILE)))
            {
                while (br.PeekChar() != EOF)
                {
                    string name = br.ReadString();//读取姓名
                    //读取表示时间的长整数，再将其转换成DateTime
                    DateTime dayOfBirth = new DateTime(br.ReadInt64());
                    string phone = br.ReadString();//读取电话
                    //将联系人对象存入列表
                    Person person = new Person() { Name = name, DayOfBirth = dayOfBirth, Phone = phone };
                    list.Add(person);
                }
            }
            return list;
        }

        //私有静态方法，将泛型列表中的数据写入文件
        private static void Save()
        {
            FileStream fs = new FileStream(DATA_FILE, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            foreach (Person p in ContactsBook.Contacts)
            {
                bw.Write(p.Name);
                bw.Write(p.DayOfBirth.Ticks);//保存日期时间对象的Tick数
                bw.Write(p.Phone);
            }

            bw.Write(EOF);
            bw.Close();
        }

        //实现增加联系人功能
        public static void Add(string name, DateTime dayOfBirth, string phone)
        {
            Person person = new Person();
            person.Name = String.IsNullOrEmpty(name) ? "未命名" : name;
            person.DayOfBirth = dayOfBirth;
            person.Phone = phone;

            ContactsBook.Contacts.Add(person);
            ContactsBook.Save();
        }

        //实现删除联系人功能
        public static void Remove(int index)
        {
            ContactsBook.Contacts.RemoveAt(index);
            ContactsBook.Save();
        }

        //实现清空通讯录功能
        public static void RemoveAll()
        {
            ContactsBook.Contacts.Clear();
            ContactsBook.Save();
        }
    }
}
