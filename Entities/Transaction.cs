using Digital_Wallet___Bank_System_OOP_Mini_Project__.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class Transaction
    {
        public Transaction( double amount , DateTime date , TransactionType type , string msg)
        {
            Id = GetUniqueId();
            Amount = amount;
            Date = date;
            Type = type;
            Message = msg;
                
        }
        public string Id { get; private set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public TransactionType Type { get; set; }
        public string Message { get; set; }

        private string GetUniqueId()
        {
            string datePart = DateTime.UtcNow.ToString("yyMMdd");
            string randomPart = Random.Shared.Next(1000, 9999).ToString();
            return datePart + randomPart;

        }

    }
}
