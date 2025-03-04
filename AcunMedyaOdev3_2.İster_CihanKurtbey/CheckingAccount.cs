using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3_2.İster_CihanKurtbey
{
    class CheckingAccount:BankAccount
    {
        public CheckingAccount(string accountHolder, int balance) :base(accountHolder,balance)
        {

            
        }

             public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest");
            
        }

    }
    }

