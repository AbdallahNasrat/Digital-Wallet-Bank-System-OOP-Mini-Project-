using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities
{
    public class WalletManager
    {
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

        }


    }

