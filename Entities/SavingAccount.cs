using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class SavingAccount : BankAccount
    {
        public SavingAccount(string ownerId) : base(ownerId)
        {
        }

        public override bool Withdraw(double value)
        {
            throw new NotImplementedException();
        }
    }
}
