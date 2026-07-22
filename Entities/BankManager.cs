using Digital_Wallet___Bank_System_OOP_Mini_Project__.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class BankManager
    {
        private readonly List<BankAccount> _accounts;

        public BankManager() {
            _accounts = new List<BankAccount>();
        }

        public BankAccount GetAccount(string id) {
            foreach (BankAccount acc in _accounts) {
                if (acc.AccountNumber == id) {
                    return acc;
                }
            }
            return null;
        }


        public bool Transfer(string sender,string receiver, double amount)
        {
            if (sender.Length!=10 && receiver.Length != 10 && amount <= 0)
                throw new Exception("Please Enter a valid data");

            BankAccount acc1 = GetAccount(sender);
            BankAccount acc2 = GetAccount(receiver);
            if(acc1 is null || acc2 is null)
                return false;

            if (acc1.Balance<amount)
            {
                return false;
            }
            try {
                acc1.Balance -= amount;
                acc2.Balance += amount;

                Transaction t1 = new Transaction(amount, DateTime.Now, TransactionType.Transfer , $"The transfer process is complete , To : {receiver} , Value = {amount}");//for sender
                Transaction t2 = new Transaction(amount, DateTime.Now, TransactionType.Transfer, $"The transfer process is complete , From : {sender} , Value = {amount}");//for receiver
                acc1.MyTransactions.Add( t1 );
                acc2.MyTransactions.Add( t2 );
                return true;
            }
            catch (Exception e) {
                throw new Exception("The process was not completed.");

            }
        }
        public BankAccount OpenSavingAccount(string ownerId) {
            BankAccount newAccount = new SavingAccount(ownerId);
            _accounts.Add(newAccount);
            return newAccount;
        }
        public BankAccount OpenCheckingAccount(string ownerId) {
            BankAccount newAccount = new SavingAccount(ownerId);
            _accounts.Add(newAccount);
            return newAccount;
        }

    }



}

        