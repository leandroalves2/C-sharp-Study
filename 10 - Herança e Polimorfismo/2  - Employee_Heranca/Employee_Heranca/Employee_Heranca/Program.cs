using Employee_Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Employee_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine().ToLower());
                if (resp == 'n')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), ci);
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else if (resp == 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), ci);
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), ci);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee item in employees) 
            {
                Console.WriteLine(item.Name + " - $ " + item.Payment().ToString("F2", ci));
            }
        }    
    }
}
