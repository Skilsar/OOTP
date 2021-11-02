using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace LR_07
{
    class ErrorName : ArgumentException
    {
        string Value
        {
            get;
            set;
        }

        public ErrorName(string message, string value) : base(message)
        {
            Value = value;
        }
    }

    class ErrorAge : ArgumentException
    {
        int Value
        {
            get;
            set;
        }

        public ErrorAge(string message, int value) : base(message)
        {
            Value = value;
        }
    }

    class ProgrammerExpError : ArgumentException
    {
        int Value
        {
            get;
            set;
        }

        public ProgrammerExpError(string message, int value) : base(message)
        {
            Value = value;
        }
    }




    class Logger
    {
        public static int countError = 0;

        public static void WriteLog(Exception ex, string filePath = @"E:\БГТУ\ООП\OOTP\LR_07\LR_07\log.txt")
        { 
                countError++;
                DateTime time = DateTime.Now;
                using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Время: {time}");
                    sw.Write($"Ошибка #{countError}: {ex.Message}\n{ex.Source}\n{ex.StackTrace}\n\n");
                }
            }
        }
    }
