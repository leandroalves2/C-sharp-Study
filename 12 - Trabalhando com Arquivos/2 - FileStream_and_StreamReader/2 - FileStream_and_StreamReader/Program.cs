using System;
using System.IO;

namespace _2___FileStream_and_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\2 - FileStream_and_StreamReader\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);               
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                Console.WriteLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    } 
}
