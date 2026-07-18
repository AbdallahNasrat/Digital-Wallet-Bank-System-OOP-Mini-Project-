using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public abstract class BankAccount
    {
        public long AccountNumber { get; set; }
        public double Balance { get; private set; }
        public int OwnerId { get; set; }

        public List<Transaction> MyTransactions { get; set; }


    }
}
