using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);

        }
        [Fact]

        public void CanTakeMoreThanYouHave()

        {
            var account = new BankAccount("Ali", 10000);

            // Test for a negative balance

            
            Assert.Throws<InvalidOperationException>(

                () => account.MakeWithdrawal(75000,
                     DateTime.Now,
                    "Attempt to overdraw") 
                ) ;
                
           
        }
        [Fact]

        public void NeedMoneyToStart()
        {
            // Test that the initial balances must be positive
            Assert.Throws<ArgumentOutOfRangeException>(

                () =>  new BankAccount("invalid", -55)
                );
        }
    }
}
//// Test that the initial balances must be positive.

//try
//{
//    var invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());

//}