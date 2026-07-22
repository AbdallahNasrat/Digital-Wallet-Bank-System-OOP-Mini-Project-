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
        }


    }
}
