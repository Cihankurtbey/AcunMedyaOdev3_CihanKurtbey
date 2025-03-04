using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaOdev3_2.İster_CihanKurtbey
{
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public int Balance { get; set; }

        public BankAccount(string accountHolder, int balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void CalculateInterest()
        {
          
        }

        
    }
}
