using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRconstraction
{
    internal class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value > 0 && value <= 1000000 ? value : 0; }
        }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public Employee(string name): this (name, 50000.00)
        {

        }
        public void Work()
        {
            Console.WriteLine($"{name}, работает, зарплата: {salary}");
        }
    }
}
