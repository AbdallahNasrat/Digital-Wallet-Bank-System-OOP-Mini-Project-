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
        public int Id { get; private set; }
        private static int _identity;
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public TransactionType Type { get; set; }
        
    }
}
