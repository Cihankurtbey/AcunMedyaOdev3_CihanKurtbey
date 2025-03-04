using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3_2.İster_CihanKurtbey
{
    class SavingsAccount : BankAccount
    {
        
        public SavingsAccount(string accountHolder, int balance) :base(accountHolder,balance)
        {
            
            

        }
        public override void CalculateInterest()
        {
            double interest = Balance * 0.05;  
            Console.WriteLine($"Interest for {AccountHolder} (Savings Account): {interest}");
        }
    }
}
