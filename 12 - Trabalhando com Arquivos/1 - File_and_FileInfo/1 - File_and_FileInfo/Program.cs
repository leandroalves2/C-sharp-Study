using System;
using System.IO;

namespace _1___File_and_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sourcePath = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\1 - File_and_FileInfo\File1.txt";
            String targetPath = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\1 - File_and_FileInfo\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }
                else 
                {
                    fileInfo.CopyTo(targetPath);
                }

                String[] lines = File.ReadAllLines(sourcePath);
                foreach (String line in lines) 
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}