using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class BankManager
    {
        public List<BankAccount> Accounts { get; private set; }
        public BankManager() {
            Accounts = new List<BankAccount>();
        }

        public BankAccount GetAccount(string id) {
            foreach (BankAccount acc in Accounts) {
                if (acc.AccountNumber == id) {
                    return acc;
                }
            }
            return null;
        }

    }
}
