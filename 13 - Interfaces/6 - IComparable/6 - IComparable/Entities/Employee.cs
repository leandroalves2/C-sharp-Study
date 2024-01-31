using System.Globalization;
using System;

namespace _6___IComparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vec = csvEmployee.Split(',');
            Name = vec[0];
            Salary = double.Parse(vec[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Compare error, argument is not Employee");
            }

            Employee other = obj as Employee;

            return Name.CompareTo(other.Name);
        }
    }
}