using Digital_Wallet___Bank_System_OOP_Mini_Project__.Entities;

namespace Digital_Wallet___Bank_System_OOP_Mini_Project__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test Register User
            //User u1 = new User();
            //u1.RegisterUserProfile("abdallah Nasrat Ahmed ", "adasd@gmail.com" , "01222222222");
            //Console.WriteLine($"ID : {u1.Id} , FullName: {u1.FullName} , Email: {u1.Email} , Phone: {u1.PhoneNumber}");
            //User u2 = new User();
            //u2.RegisterUserProfile("Youssef Nasrat Ahmed ", "youssef@gmail.com" , "01222222222");
            //Console.WriteLine($"ID : {u2.Id} , FullName: {u2.FullName} , Email: {u2.Email} , Phone: {u2.PhoneNumber}");
            #endregion


            #region test deposit & withdraw

            //Saving Account 

            //User u1 = new User("abdallah nasrat","abdallah@gmail.com","01226414024");
            //BankAccount account = new SavingAccount(u1.Id.ToString());
            //Console.WriteLine("balance : " + account.Balance);
            //account.Deposit(1000);
            //Console.WriteLine("balance now :" + account.Balance);

            //Console.WriteLine(account.Withdraw(1000));
            //Console.WriteLine("balance now :"+account.Balance);

            //Checking Account

            //User u2 = new User("ahmed khaled", "ahmed@gmail.com", "01226414024");
            //BankAccount ac2 = new CheckingAccount(u2.Id.ToString());
            //Console.WriteLine("balance : " + ac2.Balance);
            //ac2.Deposit(1000);
            //Console.WriteLine("balance now :" + ac2.Balance);

            //Console.WriteLine(ac2.Withdraw(1000));
            //Console.WriteLine("balance now :"+ac2.Balance);

            //Console.WriteLine(ac2.Withdraw(100));
            //Console.WriteLine("balance now :"+ac2.Balance);

            #endregion
            #region Test Transfer

            //BankManager manager = new BankManager();
            //User u1 = new User("Abdallah Nasrat ", "hasdas@gmail.com", "01226414024");
            //User u2 = new User("Youssef Nasrat ", "hasdas@gmail.com", "01226414024");

            //var acc1 = manager.OpenCheckingAccount(u1.Id.ToString());
            //var acc2 = manager.OpenCheckingAccount(u2.Id.ToString());

            //bool isSuccess = manager.Transfer(acc1.AccountNumber, acc2.AccountNumber, 5000);
            //Console.WriteLine(isSuccess);
            //acc1.Deposit(5000);
            //Console.WriteLine("after add 5000 to acc1 :");
            // isSuccess = manager.Transfer(acc1.AccountNumber, acc2.AccountNumber, 5000);
            //Console.WriteLine(isSuccess);
            #endregion
            #region Test Link Wallet To BankAccount

            //BankManager manager = new BankManager();
            //WalletManager walletManager = new WalletManager();

            ////true case
            //User u1 = new User("Abdallah Nasrat ", "hasdas@gmail.com", "01226414024");
            //var acc1 = manager.OpenCheckingAccount(u1.Id.ToString());
            //DigitalWallet wallet = walletManager.CreateWallet(u1.Id.ToString());
            //bool isSuccsess = walletManager.LinkWalletToAccountBank(wallet.WalletId, acc1.AccountNumber, manager);


            //if (isSuccsess) {
            //    Console.WriteLine($"wallet with id : {wallet.WalletId} linked with bank account with id {acc1.AccountNumber} ");
            //}else
            //    Console.WriteLine("link is not done ");

            ////false case
            // isSuccsess = walletManager.LinkWalletToAccountBank("123","124", manager);
            //if (isSuccsess)
            //{
            //    Console.WriteLine($"wallet with id : {wallet.WalletId} linked with bank account with id {acc1.AccountNumber} ");
            //}
            //else
            //    Console.WriteLine("link is not done ");
            #endregion
            #region test TopUPWallet

            //BankManager manager = new BankManager();
            //WalletManager walletManager = new WalletManager(manager);

            //User u1 = new User("Abdallah Nasrat ", "hasdas@gmail.com", "01226414024");
            //var acc1 = manager.OpenCheckingAccount(u1.Id.ToString());
            //DigitalWallet wallet = walletManager.CreateWallet(u1.Id.ToString());
            //walletManager.LinkWalletToAccountBank(wallet.WalletId, acc1.AccountNumber, manager);
            //acc1.Deposit(500);
            //Console.WriteLine($"acc1 balance = {acc1.Balance}");

            //bool isSuccess =walletManager.TopUpWallet(wallet.WalletId, 400);
            //if (isSuccess)
            //{
            //    Console.WriteLine($"acc1 balance after TopUPWallet {acc1.Balance}");
            //    Console.WriteLine($"wallet after addfunds = {wallet.Balance}");

            //}
            //else {
            //    Console.WriteLine("the process is not complete");
            //}
            //walletManager.TopUpWallet(wallet.WalletId, 200);
            //Console.WriteLine($"acc1 balance after TopUPWallet {acc1.Balance}");
            //Console.WriteLine($"wallet after addfunds = {wallet.Balance}");

            #endregion
            #region test Transaction 
            //User u1 = new User("Abdallah Nasrat ","Abdallah@gmail.com","01226414024");
            //User u2 = new User("Abdallah 2 ","Abdallah2@gmail.com","01226414024");
            //BankManager bankManager = new BankManager();
            //BankAccount abdallahAcc = bankManager.OpenSavingAccount(u1.Id.ToString());
            //BankAccount abdallahAcc2 = bankManager.OpenSavingAccount(u2.Id.ToString());
            //abdallahAcc.Deposit(100);
            //abdallahAcc.Deposit(200);
            //abdallahAcc.Withdraw(20);
            //bankManager.Transfer(abdallahAcc.AccountNumber, abdallahAcc2.AccountNumber, 50);
            //var myTransaction = abdallahAcc.GetTransactionHistory();
            //foreach (Transaction t in myTransaction) {
            //    Console.WriteLine($"{t.Id}  , {t.Amount}   , {t.Date}   , {t.Type}    , {t.Message}");
            //}
            //Console.WriteLine("--------------------------");
            //WalletManager walletManager = new WalletManager(bankManager);
            //DigitalWallet wallet = walletManager.CreateWallet(u1.Id.ToString());
            //wallet.AddFunds(100);
            //var trans = wallet.MyTransaction;
            //foreach (Transaction t in trans)
            //{
            //    Console.WriteLine($"{t.Id}  , {t.Amount}   , {t.Date}   , {t.Type}    , {t.Message}");
            //}





            #endregion

            ///////////////////////////////////////////// User Interface ////////////////////////////


            Console.WriteLine(" 1-Create user");
            Console.WriteLine(" 2-Open Bank Account");
            Console.WriteLine(" 3-Deposit");
            Console.WriteLine(" 4-Withdraw");
            Console.WriteLine(" 5-Transfer to bank account");
            Console.WriteLine(" 6-Transfer to Digital Wallet");
            Console.WriteLine(" 7-Open Digital Wallet");
            Console.WriteLine(" 8-MyBalance - Bank");
            Console.WriteLine(" 9-MyBalance - Wallet");
            Console.WriteLine(" 10-Show My Information");
            Console.WriteLine(" 11-Show My Transaction");

            bool flag = int.TryParse(Console.ReadLine(), out int value);
            if (flag) {
                switch (value) {
                    case 1: {
                            Console.Write("Enter  fullName : ");
                            string fullName = Console.ReadLine();
                            Console.Write("Enter  phone number : ");
                            string phoneNumber = Console.ReadLine();
                            Console.Write("Enter  email : ");
                            string email = Console.ReadLine();

                            User u = new User(fullName, email, phoneNumber);
                            if (u is not null) {
                                Console.WriteLine($"The user account was successfully created, with owner Id = {u.Id}");
                            }
                            break;
                            
                            
                    }
                    case 2: {
                            Console.WriteLine();

                            break;
                        
                        }
                    case 3: {

                            break;
                        
                        }
                    case 4: {

                            break;
                        
                        }
                    case 5: {

                            break;
                        
                        }
                    case 6: {

                            break;
                        
                        }
                    case 7: {

                            break;
                        
                        }
                    case 8: {

                            break;
                        
                        }
                    case 9: {

                            break;
                        
                        }
                    case 10: {

                            break;
                        
                        }
                    case 11: {

                            break;
                        
                        }
                }
            }
            else {
                Console.WriteLine("Enter valid Digit");
                    }




        }


    }
}
