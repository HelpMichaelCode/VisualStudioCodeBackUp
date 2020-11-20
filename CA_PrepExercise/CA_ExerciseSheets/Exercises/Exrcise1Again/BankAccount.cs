namespace Exrcise1Again
{
    public abstract class BankAccount 
    {
        private readonly string _accNum; //  Variable
        public string AccountNumber // This returns the variable up top
        {
            get
            {
                return _accNum;
            }
        }

        private double _balance;
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
        // Balance = 99.99 -> set{} -> balance = 99.99(value)

        public BankAccount(string accNumber)
        {
            _accNum = accNumber;
            Balance = 0;
        }

        public abstract void MakeDeposit(double amount);
        public abstract void MakeWithdrawal(double amount);

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n" +
                   $"Balance: {Balance}";
        }
    }
}
