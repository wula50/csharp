using System;
using System.IO;
namespace CSharp.Unit6.Eg6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1, path2;
            path1 = @"c:\mydir\subdir\test";
            path2 = @"temp\data.bin";

            Console.WriteLine("GetDirectoryName: {0}, {1}", Path.GetDirectoryName(path1), Path.GetDirectoryName(path2));
            Console.WriteLine("GetExtension: {0}, {1}", Path.GetExtension(path1), Path.GetExtension(path2));
            Console.WriteLine("GetFileName: {0}, {1}", Path.GetFileName(path1), Path.GetFileName(path2));
            Console.WriteLine("GetFullPath: {0}, {1}", Path.GetFullPath(path1), Path.GetFullPath(path2));
            Console.WriteLine("IsPathRooted: {0}, {1}", Path.IsPathRooted(path1), Path.IsPathRooted(path2));
            Console.WriteLine("GetTempPath:{0}", Path.GetTempPath());
            Console.WriteLine("GetTempFileName:{0}", Path.GetTempFileName());
            Console.WriteLine("GetRandomFileName: {0}", Path.GetRandomFileName());
            Console.WriteLine("Combine: {0}", Path.Combine(path1, path2));
            Console.WriteLine("ChangeExtension: {0}", Path.ChangeExtension(path1, "EXT"));
            Console.WriteLine("ChangeExtension: {0}", Path.ChangeExtension(path2, "EXT"));

            Console.ReadKey();
        }
    }
}
