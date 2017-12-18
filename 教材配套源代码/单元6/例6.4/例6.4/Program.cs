using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;


namespace CSharp.Unit6.Eg6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\mydir";

            Directory.CreateDirectory(path);
            Console.WriteLine("当前工作路径:" + Directory.GetCurrentDirectory());

            Directory.SetCurrentDirectory(path);
            Console.WriteLine("重设后的工作路径:" + Directory.GetCurrentDirectory());

            Directory.CreateDirectory("subdir1");
            Directory.CreateDirectory("subdir2");

            File.CreateText("temp.txt");
            File.CreateText("temp.bin");

            Console.WriteLine("\n'subdir1'的Parent：" + Directory.GetParent("subdir1"));
            Console.WriteLine("'subdir2'的DirectoryRoot：" + Directory.GetDirectoryRoot("subdir2"));

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
            string[] subdirs = Directory.GetDirectories(path);
            string[] entries = Directory.GetFileSystemEntries(path);
            string[] drives = Directory.GetLogicalDrives();

            Console.WriteLine("\n" + Directory.GetCurrentDirectory() + "目录下的*.txt文件：");
            foreach (string file in files)
                Console.WriteLine(file);

            Console.WriteLine("\n'c:\\mydir'目录下的子文件夹");
            foreach (string dir in subdirs)
                Console.WriteLine(dir);

            Console.WriteLine("\n'c:\\mydir'目录下的子文件夹和文件");
            foreach (string entry in entries)
                Console.WriteLine(entry);

            Console.WriteLine("\n'计算机中的逻辑驱动器：");
            foreach (string drv in drives)
                Console.Write(drv + "  ");

            Console.ReadKey(true);

        }
    }
}
