using System;
using System.IO;

namespace _4___StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\4 - StreamWriter\File1.txt";
            string targetPath = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\4 - StreamWriter\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                { 
                    foreach (string line in lines) 
                    {
                        sw.WriteLine(line.ToUpper());
                    }
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
