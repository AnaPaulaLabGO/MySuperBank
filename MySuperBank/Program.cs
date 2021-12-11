using BankyStuffLibrary;
using System;


namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("car".Pluralize());
            //Console.WriteLine("pant".Pluralize());
            //Console.WriteLine("octopus".Pluralize());

            //Console.WriteLine(3501.ToWords());

            var account = new BankAccount("Ali", 10000);
            Console.WriteLine($"Account {account.Number} was create for {account.Owner} with {account.Balance} .");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
                             
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawal(5, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5, DateTime.Now, "Diet Coke");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(7, DateTime.Now, "Tea");
            account.MakeWithdrawal(8, DateTime.Now, "Bars");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
