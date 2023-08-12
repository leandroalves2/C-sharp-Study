using System;
using System.Globalization;
using System.Collections.Generic;


namespace _8_exercicioFixacao {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("How many employees will be registered? ");
            int registro = int.Parse(Console.ReadLine());

            List<Dados> list = new List<Dados>();
            Console.WriteLine();

            for (int i = 0; i < registro; i++) {
                Console.WriteLine("Emplyoee #{0}:", i+1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), ci);
                list.Add(new Dados(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int consulta = int.Parse(Console.ReadLine());


            Dados pos = list.Find(x => x.Id == consulta);
            if (pos != null) {
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine(), ci);
                pos.AumentoSalario(perc);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Dados obj in list) {
                Console.WriteLine(obj);
            }

        }
    }




}
