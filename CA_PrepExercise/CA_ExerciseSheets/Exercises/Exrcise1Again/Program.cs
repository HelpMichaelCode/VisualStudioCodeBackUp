using System;

namespace Exrcise1Again
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing purposes
            //BankAccount account = new BankAccount("GDFUEQWV31");
            //Console.WriteLine(account);
            CurrentAccount m = new CurrentAccount(25.00, "JFHBVWJH3");
            m.MakeDeposit(100);
            m.MakeWithdrawal(50);
            Console.WriteLine(m);
        }
    }
}
