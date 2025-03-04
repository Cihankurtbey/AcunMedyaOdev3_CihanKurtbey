using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3_CihanKurtbey
{
    class Developer : Employee
    {
        public string About { get; set; }
        public Developer(int id, string name, decimal salary, string department, string about)
       : base(id, name, salary, department) // base ile miras aldığımız sınıfın constructor ını çağırdım
        {
            About = about;
        }

        
        public override decimal CalculateBonus()
        {
            return Salary * 0.1m;
        }
    }
}
