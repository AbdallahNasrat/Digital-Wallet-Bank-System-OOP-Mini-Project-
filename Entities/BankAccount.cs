using Digital_Wallet___Bank_System_OOP_Mini_Project__.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public abstract class BankAccount
    {
        protected BankAccount(string ownerId )
        {
            AccountNumber = GetUniqueAccountNumber();
            OwnerId = ownerId;
            MyTransactions = new List<Transaction>();

        }
        public string AccountNumber { get; init; }
        private double _balance;
        public double Balance {
            get => _balance;
            set => _balance  = value;
                
            } 
        
        public string OwnerId { get; init; }

        public List<Transaction> MyTransactions { get; set; }

        private string GetUniqueAccountNumber() {
            string datePart = DateTime.UtcNow.ToString("yyMMdd");
            string randomPart = Random.Shared.Next(1000, 9999).ToString();
            return datePart + randomPart;

        }

        public bool Deposit(double value) {
            if (value <= 0)
                throw new Exception("Please Enter value greater than 0 ");
            Balance += value;
            Transaction transaction = new Transaction(amount: value
                ,date: DateTime.UtcNow, type: TransactionType.deposit);
            MyTransactions.Add(transaction);
                
            return true;
        }

        public abstract bool Withdraw(double value);

        public double GetBalance() {
            return Balance;
        }

        
        


    }
}
