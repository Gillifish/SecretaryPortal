using System;
using System.IO;

namespace SinfonianAttendance.Data
{
    public class FileData
    {
        public static void ReadFileToConsole(string filename)
        {
            string txt = File.ReadAllText(filename);
            Console.WriteLine(txt);
        }

        public static void AppendFile(string sinfonian, string filename) =>
            File.AppendAllText(filename, sinfonian);
        
    }
}