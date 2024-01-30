using System;
using System.IO;
using System.Collections.Generic;

namespace _5___Directory_and_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\5 - Directory_and_DirectoryInfo\myfolder";

            try 
            { 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
