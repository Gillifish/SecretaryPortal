using System;
using System.IO;

namespace SecretaryPortal.Data
{
    public class FileData
    {
        public static void ReadFileToConsole(string filename)
        {
            string txt = File.ReadAllText(filename);
            Console.WriteLine(txt);
        }

        public static void AppendFile(string strData, string filename) =>
            File.AppendAllText(filename, strData);
        
    }
}