using System;
using System.IO;

namespace CSharp.Unit6.Eg6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\mydir";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (!dir.Exists)
            {
                dir.Create();
            }

            Directory.SetCurrentDirectory(path);

            DirectoryInfo subdir1 = new DirectoryInfo("subdir1");
            DirectoryInfo subdir2 = new DirectoryInfo("subdir2");
            FileInfo file1 = new FileInfo("temp.txt");
            FileInfo file2 = new FileInfo("temp.bin");

            subdir1.Create();
            subdir2.Create();
            file1.Create().Close();
            file2.Create().Close();

            FileInfo[] files = dir.GetFiles("*.txt");
            DirectoryInfo[] subdirs = dir.GetDirectories();
            FileSystemInfo[] fs = dir.GetFileSystemInfos();

            Console.WriteLine(dir.FullName + "目录下的*.txt文件：");
            foreach (FileInfo file in files)
                Console.WriteLine(file.Name);

            Console.WriteLine("\nc:\\mydir目录下的子文件夹:"); foreach (DirectoryInfo subdir in subdirs)
                Console.WriteLine(subdir.Name);

            Console.WriteLine("\n" + dir.Name + "目录下的子文件夹和文件:");
            Console.WriteLine("【完整名称】\t\t【名称】\t【类型】");
            foreach (FileSystemInfo info in fs)
                Console.WriteLine("{0}\t{1}\t{2}", info.FullName, info.Name
                    , info.Extension);

            Console.ReadKey(true);
        }
    }
}
