using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3_CihanKurtbey
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(int ıd, string name, decimal salary, string department)
        {
            Id = ıd;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public virtual decimal CalculateBonus ()
        {

            return 0;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}, Bonus: {CalculateBonus()}");
        }
    }
}
