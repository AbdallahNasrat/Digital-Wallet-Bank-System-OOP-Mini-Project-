using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public abstract class BankAccount
    {
        protected BankAccount(string ownerId)
        {
            AccountNumber = GetUniqueAccountNumber();
            OwnerId = ownerId;

        }
        public string AccountNumber { get; init; }
        public double Balance { get; private set; }
        public string OwnerId { get; init; }

        public List<Transaction> MyTransactions { get; set; }

        private string GetUniqueAccountNumber() {
            string datePart = DateTime.UtcNow.ToString("yyMMdd");
            string randomPart = Random.Shared.Next(1000, 9999).ToString();
            return datePart + randomPart;

        }


    }
}
