using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        Console.WriteLine("名称\t类型\t卷标\t格式\t可用空间\t总大小");
        foreach (DriveInfo d in drives)
        {
            Console.Write("{0}\t{1}\t",
                d.Name, d.DriveType);
            //光驱为插入光盘时不能访问卷标、文件系统格式等属性
            if (d.IsReady)
                Console.Write("{0}\t{1}\t{2}\t{3}",
                d.VolumeLabel, d.DriveFormat, d.AvailableFreeSpace, d.TotalSize);

            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
