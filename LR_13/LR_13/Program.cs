using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using static LR_13.HGGLog;

namespace LR_13
{
    class Program
    {
        static void Main(string[] args)
        {
            HGGDiskInfo diskInfo = new HGGDiskInfo();
            diskInfo.DiskInfo();
            HGGFileInfo fileInfo = new HGGFileInfo();
            fileInfo.FileData(@"E:\БГТУ\!HELP\ООТП_HELP\OOP_BSTU-master\laba13\laba13\Class1.cs");
            HGGDirInfo dirInfo = new HGGDirInfo();
            dirInfo.DirInfo(@"E:\БГТУ\ООП\OOTP\LR_13\LR_13");
            HGGFileManager fileManager = new HGGFileManager();
            fileManager.FileManager(@"E:\БГТУ\ООП\OOTP\LR_13\LR_13");

        }
    }
}
