using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class CurrentAccount : BankAccount
    {
        private readonly double overdraftLimit;
        List<AccountTransaction> transactions;

        public double OverdraftLimit
        {
            get
            {
                return overdraftLimit;
            }
        }
        public CurrentAccount(string accNum, double overdraftLimit) : base(accNum)
        {
            this.overdraftLimit = overdraftLimit;
            transactions = new List<AccountTransaction>();
        }

        public override void MakeDeposit(double amount)
        {
            Balance += amount;
            transactions.Add(new AccountTransaction(TransactionType.Deposit, amount));
        }

        public override void MakeWithdrawal(double amount)
        {
            if(Balance < 0)
            {
                throw new Exception("Insufficient Funds!");
            }
            else
            {
                Balance -= amount;
                transactions.Add(new AccountTransaction(TransactionType.Withdrawal, amount));
            }
        }

        public override string ToString()
        {
            string logHistory = "";
            foreach (var item in transactions)
            {
                logHistory += $"{item.ToString()}\n";
            }
            return $"Current Account details\n" +
                   $"-----------------------\n" +
                   $"{base.ToString()}\n" +
                   $"Transaction Histroy\n" +
                   $"-----------------------\n" +
                   $"{logHistory}";
        }
    }
}
