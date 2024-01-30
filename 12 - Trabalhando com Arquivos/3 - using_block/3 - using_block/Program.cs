using System;
using System.IO;

namespace _3___using_block
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String path = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\3 - using_block\File1.txt";

            try
            {

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                Console.WriteLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();


            }
            catch (IOException e) 
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}