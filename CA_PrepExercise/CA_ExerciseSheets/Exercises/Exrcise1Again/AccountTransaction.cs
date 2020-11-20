using System;
namespace Exrcise1Again
{
    public enum TransactionType
	{
		Deposit, Withdrawal
    }

    public class AccountTransaction
    {
		private TransactionType type;       // deposit/withdrawal
		private double amount;          // amount concerned

		// constructor
		public AccountTransaction(TransactionType type, double amount)
		{
			this.type = type;
			this.amount = amount;
		}

		// return human readable String
		public override String ToString()
		{
			return $"Type: {type}\n" +
                   $"Amount: {amount}";
		}
	}
}
