using _6___IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace _6___IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Documentos\Estudos\C#\13 - Interfaces\6 - IComparable\in.txt";

            try 
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employee = new List<Employee>();
                    while (!sr.EndOfStream) 
                    {

                        employee.Add(new Employee(sr.ReadLine()));
                    }

                    Console.WriteLine("Lista não ordenada: ");
                    foreach (Employee emp in employee) 
                    {
                        Console.WriteLine(emp);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Lista ordenada");
                    employee.Sort();
                    foreach (Employee emp in employee)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}