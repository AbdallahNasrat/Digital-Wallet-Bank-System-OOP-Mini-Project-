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

            User u2 = new User("ahmed khaled", "ahmed@gmail.com", "01226414024");
            BankAccount ac2 = new CheckingAccount(u2.Id.ToString());
            Console.WriteLine("balance : " + ac2.Balance);
            ac2.Deposit(1000);
            Console.WriteLine("balance now :" + ac2.Balance);

            Console.WriteLine(ac2.Withdraw(1000));
            Console.WriteLine("balance now :"+ac2.Balance);

            Console.WriteLine(ac2.Withdraw(100));
            Console.WriteLine("balance now :"+ac2.Balance);

            #endregion
        }


    }
}
