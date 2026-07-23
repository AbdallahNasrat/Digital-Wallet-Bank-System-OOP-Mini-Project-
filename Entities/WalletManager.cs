using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class WalletManager
    {
        private BankManager _bankManager;
        public WalletManager(BankManager bankManager)
        {           
            _bankManager = bankManager;
        }
        private List<DigitalWallet> _wallets = new List<DigitalWallet>();
        public DigitalWallet CreateWallet(string ownerId) {
            DigitalWallet wallet = new DigitalWallet(ownerId);
            _wallets.Add(wallet);
            return wallet;

        }
        public bool LinkWalletToAccountBank(string walletId, string bankAccId , BankManager bankManager) {

            DigitalWallet wallet = _wallets.FirstOrDefault(w => w.WalletId == walletId);
            if (wallet == null) {
                return false;
            }
            BankAccount bankAccount = bankManager.GetAccount(bankAccId);
            if (bankAccount == null) {
                return false;
            }
            wallet.LinkedBankAccountId = bankAccId;
            return true;
        }
        public bool TopUpWallet(string walletId, double amount) {
            DigitalWallet wallet = _wallets.FirstOrDefault(d => d.WalletId == walletId);
            if (wallet == null) {
                return false;
            }
            if (string.IsNullOrEmpty(wallet.LinkedBankAccountId)) {
                return false;
            }

            BankAccount acc = _bankManager.GetAccount(wallet.LinkedBankAccountId);
            if (acc == null) { 
                return false;
            }
            if (acc.Withdraw(amount)) {
                wallet.AddFunds(amount);
                return true;
            }
            return false;

        }   

    }


}

