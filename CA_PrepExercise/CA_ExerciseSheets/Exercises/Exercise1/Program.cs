using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing purposes
            // BankAccount bankAccount = new BankAccount("DWEJH32");
            // Console.WriteLine(bankAccount);

            CurrentAccount account1 = new CurrentAccount("123qwe", 21.21);
            account1.MakeDeposit(100.00);
            account1.MakeWithdrawal(12.00);
            CurrentAccount account2 = new CurrentAccount("145op", 21.21);
            account2.MakeDeposit(100.00);
            account2.MakeWithdrawal(12.00);
            Console.WriteLine(account2);
            Console.WriteLine(account1);
        }
    }
}
