using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace LR_13
{
    public static class HGGLog
    {
        public const string logFile = @"E:\БГТУ\ООП\OOTP\LR_13\LR_13\HGGLogFIle.txt"; //путь к файлу       

        static HGGLog()
        {
            using (StreamWriter w = new StreamWriter(logFile, false)) { }
        }

        public static void WriteLine(string str)
        {
            try //отлов ошибки
            {
                using (StreamWriter w = new StreamWriter(logFile, true)) //создание потока 
                {
                    w.WriteLine(str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public static void SearchByString(string str) //поиск по строке 
        {
            using (StreamReader sr = new StreamReader(logFile, false)) //считывание строк
            {
                while (!sr.EndOfStream)
                {
                    if (sr.ReadLine().StartsWith(str))
                        Console.WriteLine(sr.ReadLine());
                }
            }
        }

        public class HGGDiskInfo
        {
            public void DiskInfo()
            {
                HGGLog.WriteLine("Информация о диске:");
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    HGGLog.WriteLine("\tИмя: " + drive.Name); //вывод инфомации о диске 
                    HGGLog.WriteLine("\tТип: " + drive.DriveType);
                    if (drive.IsReady)
                    {
                        HGGLog.WriteLine("\tФайловая система: " + drive.DriveFormat);
                        HGGLog.WriteLine($"\tОбъем свободного места: всего - {drive.TotalFreeSpace / 1000 / 1000 / 1000} GB, доступно - { drive.AvailableFreeSpace / 1024 / 1024 / 1024} GB");
                        HGGLog.WriteLine($"\tОбщий размер: {drive.TotalSize / 1024 / 1024 / 1024} GB");
                        HGGLog.WriteLine("\tМетка тома диска: " + drive.VolumeLabel);
                    }
                    HGGLog.WriteLine("");
                }
            }
        }
        public class HGGFileInfo
        {
            public void FileData(string path)
            {
                HGGLog.WriteLine("Информация о файле:"); //метод вывода инфомации о файле 
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    HGGLog.WriteLine($"\tПолный путь: {fileInf.DirectoryName}");
                    HGGLog.WriteLine($"\tИмя: {fileInf.Name}");
                    HGGLog.WriteLine($"\tОбъем: {fileInf.Length}\n\tРасширение: {fileInf.Extension}\n\tДата создания: {fileInf.CreationTime}");
                }
                else
                {
                    HGGLog.WriteLine("Такого файла не существует");
                }
            }
        }
        public class HGGDirInfo
        {
            public void DirInfo(string dirName)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName); //вывод инфомации о директории 
                HGGLog.WriteLine("\nИнформация о директории:");
                HGGLog.WriteLine($"\tКоличество файлов: {dirInfo.GetFiles().Count()}");
                HGGLog.WriteLine($"\tДата создания: {dirInfo.CreationTime}");
                HGGLog.WriteLine($"\tПодкаталоги: {dirInfo.GetDirectories("*", SearchOption.AllDirectories).Count()}");
                HGGLog.WriteLine($"\tРодительская директория: {dirInfo.Parent}");
            }
        }

    }

    public class HGGFileManager
    {
        public void FileManager(string path) //метод вывода инфомации о директориях и файлах 
        {
            try
            {
                DriveInfo driveInfo = new DriveInfo(path);
                DirectoryInfo dirInfo = Directory.CreateDirectory(@"E:\БГТУ\ООП\OOTP\LR_13\LR_13\HGGInspect");
                using (StreamWriter writer = File.CreateText(@"E:\БГТУ\ООП\OOTP\LR_13\LR_13\HGGInspect\HGGDirInfo.txt"))
                {
                    writer.WriteLine("Информация");
                }
                File.Copy(dirInfo.FullName + "\\HGGDirInfo.txt", dirInfo.FullName + "\\copied.txt");
                //File.Delete(dirInfo.FullName + "\\HGGDirInfo.txt");
                DirectoryInfo dirInfo1 = Directory.CreateDirectory(driveInfo.Name + "ALLFiles");
                DirectoryInfo currentDirectory = new DirectoryInfo("./");
                foreach (var item in currentDirectory.GetFiles())
                    item.CopyTo(dirInfo1.FullName + "\\" + item.Name, true);
                dirInfo1.MoveTo(dirInfo.FullName + "\\" + dirInfo1.Name);
                DirectoryInfo dirInfo2 = new DirectoryInfo(dirInfo.FullName + "\\" + dirInfo1.Name);
                ZipFile.CreateFromDirectory(dirInfo2.FullName, dirInfo.FullName + "\\arhive.zip");
                DirectoryInfo exInfo = Directory.CreateDirectory(dirInfo.FullName + "\\Ezvlechen");
                using (ZipArchive arch = ZipFile.OpenRead(dirInfo.FullName + "\\arhive.zip"))
                {
                    foreach (ZipArchiveEntry entry in arch.Entries)
                    {
                        entry.ExtractToFile(exInfo.FullName + "\\Ezvlechen_" + entry.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
