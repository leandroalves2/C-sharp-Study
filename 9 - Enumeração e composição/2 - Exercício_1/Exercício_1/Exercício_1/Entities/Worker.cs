using System;
using Exercício_1.Entities.Enums;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Exercício_1.Entities {
    internal class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departaments Departaments { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() 
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departaments departaments) 
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departaments = departaments;
        }

        public void AddContract(HourContract contract) 
        { 
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum = sum + contract.TotalVale();
            }
            return sum;
        }
    }
}
