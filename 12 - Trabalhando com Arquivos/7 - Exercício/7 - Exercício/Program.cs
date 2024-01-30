using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace _7___Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            string sourcePath = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\7 - Exercício\file1.txt";
            string targetPath = @"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\7 - Exercício\out\summary.csv";
            CultureInfo ci = CultureInfo.InvariantCulture;

            try
            {

                StreamWriter sw = File.CreateText(sourcePath);
                sw.WriteLine("TV LED,1290.99,1");
                sw.WriteLine("Video Game Chair,350.50,3");
                sw.WriteLine("Iphone X,900.00,2");
                sw.WriteLine("Samsung Galaxy 9,850.00,2");
                sw.Close();               

                List<string> nome = new List<string>();
                List<double> valor = new List<double>();
                List<int> qtd = new List<int>();

                string[] linhas = File.ReadAllLines(sourcePath);
                foreach (var linha in linhas)
                {
                    string[] partes = linha.Split(',');
                    if (partes.Length == 3)
                    {
                        nome.Add(partes[0]);
                        valor.Add(double.Parse(partes[1], ci));
                        qtd.Add(int.Parse(partes[2]));
                    }
                    else
                    {
                        Console.WriteLine($"Formato inválido na linha: {linha}");
                    }
                }

                List<double> total = new List<double>();

                for (int i = 0; i < qtd.Count; i++)
                {
                    total.Add(valor[i] * qtd[i]);
                }

                Directory.CreateDirectory(@"D:\Documentos\Estudos\C#\12 - Trabalhando com Arquivos\7 - Exercício\out");

                List<string> saida = new List<string>();
                for (int i = 0; i < total.Count; i++)
                {
                    saida.Add(nome[i] + ", " + total[i].ToString("F2", ci));
                }

                using (sw = File.AppendText(targetPath))
                {
                    for (int i = 0; i < total.Count; i++)
                    {
                        sw.WriteLine(saida[i], ci);
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