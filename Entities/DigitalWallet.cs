using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class DigitalWallet
    {
        public string WalletId { get; private init; }
        public string OwnerId { get; private init; }
        public double Balance { get; set; }
        private string _linkedBankAccountId;
        public string LinkedBankAccountId {
            get { return _linkedBankAccountId; }
            set {
                if (string.IsNullOrEmpty(_linkedBankAccountId))
                    _linkedBankAccountId = value;
                else {
                    throw new Exception("Can not link wallet by another Account");
                }
            }
        }
        public List<Transaction> MyTransaction { get; private set; }


        public DigitalWallet(string ownerId)
        {
            OwnerId = ownerId;
            WalletId = GetUniqueWalletNumber();
            MyTransaction = new List<Transaction>();
        }
        private string GetUniqueWalletNumber()
        {
            string datePart = DateTime.UtcNow.ToString("yyMMdd");
            string randomPart = Random.Shared.Next(1000, 9999).ToString();
            return datePart + randomPart;

        }
        public bool AddFunds(double amount) {
            if (amount <= 0)
                return false;
            else {
                Balance += amount;
                Transaction t = new Transaction(amount, DateTime.Now, Enum.TransactionType.deposit, $"An amount of: {amount}$ was deposited");
                MyTransaction.Add(t);
                return true;
            }
        }

    }
}
