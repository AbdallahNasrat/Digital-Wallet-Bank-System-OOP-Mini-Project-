using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class DigitalWallet
    {
        public int WalletId { get; set; }
        public int OwnerId { get; set; }
        public double Balance { get; set; }
        public int LinkedBankAccountId { get; set; }
    }
}
