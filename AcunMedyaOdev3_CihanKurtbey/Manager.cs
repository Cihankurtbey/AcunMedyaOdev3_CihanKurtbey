using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AcunMedyaOdev3_CihanKurtbey
{
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(int id, string name, decimal salary, string department, int teamSize)
       : base(id, name, salary, department)
        {
            TeamSize = teamSize;
        }
        public override decimal CalculateBonus()
        {
            return Salary * 0.2m;
        }
    }
}
