using System;
using System.Collections.Generic;

namespace Exrcise1Again
{
    public class CurrentAccount : BankAccount
    {
        List<AccountTransaction> transactions;
        private readonly double _overDraft;
        public double Overdraft
        {
            get
            {
                return _overDraft;
            }
        }

        public CurrentAccount(double overDraft, string accountNum) : base(accountNum)
        {
            _overDraft = overDraft;
            transactions = new List<AccountTransaction>();
        }

        public override void MakeDeposit(double amount)
        {
            Balance += amount;
            transactions.Add(new AccountTransaction(TransactionType.Deposit, Balance));
        }

        public override void MakeWithdrawal(double amount)
        {
            if (amount <= (Balance + Overdraft))
            {
                Balance -= amount;
                transactions.Add(new AccountTransaction(TransactionType.Withdrawal, amount));
            }
            else
            {
                throw new Exception("Insufficient Funds!");
            }
        }

        public override string ToString()
        {
            string transactionHistory = "";
            foreach (var item in transactions)
            {
                transactionHistory += $"{item.ToString()}\n";
            }
            return $"Current Account details\n" +
                   $"-----------------------\n" +
                   $"{base.ToString()}\n" +
                   $"Transaction Histroy\n" +
                   $"-----------------------\n" +
                   $"{transactionHistory}";
        }
    }
}
