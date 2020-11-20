using System;
namespace Exercise1
{
    public abstract class BankAccount
    {
        private readonly string _accNum;
        private double _balance;
        public string AccountNumber
        {
            get
            {
                return _accNum;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public BankAccount(string accNum)
        {
            _accNum = accNum;
            Balance = 0;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n" +
                   $"Balance: €{Balance}"; 
        }

        public abstract void MakeDeposit(double amount);
        public abstract void MakeWithdrawal(double amount);
    }
}
