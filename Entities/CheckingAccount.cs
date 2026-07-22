using Digital_Wallet___Bank_System_OOP_Mini_Project__.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string ownerId) : base(ownerId)
        {
        }

        public override bool Withdraw(double value)
        {
            if (value <= 0) {
                throw new Exception("Enter value greater than Zero .");
            }
            if (Balance >= value) {
                Balance -= value;
                Transaction t = new Transaction(value, DateTime.Now, TransactionType.Withdraw, $"The withdrawal process is complete , value = {value} ");
                MyTransactions.Add(t);
                return true;

            }
            return false;
        }
    }
}
