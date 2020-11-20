using System;
namespace Lab5EnumsAndStructs
{
    public struct Money
    {
        public double MoneyAmount { get; set; }
        public string CurrencyUnit { get; set; }
        public const double USrates = 1.17648;
        public const double EuroRates = 0.849992;
        public const double YenRates = 124.715;

        public Money(int moneyAmount, string currencyUnit)
        {
            this.MoneyAmount = moneyAmount;
            this.CurrencyUnit = currencyUnit;
        }

        public static double EuroToUS(Money money)
        {
            return Math.Round((money.MoneyAmount * USrates), MidpointRounding.ToEven);
        }

        public static double EuroToYen(Money money)
        {
            return Math.Round((money.MoneyAmount * YenRates), MidpointRounding.ToEven);
        }

        public static double USToEuro(Money money)
        {
            return Math.Round((money.MoneyAmount * EuroRates), MidpointRounding.ToEven);
        }

        public static double USToYen(Money money)
        {
            return Math.Round((money.MoneyAmount * YenRates), MidpointRounding.ToEven);
        }

        public static double YenToEuro(Money money)
        {
            return Math.Round((money.MoneyAmount * EuroRates), MidpointRounding.ToEven);
        }

        public static double YenToUS(Money money)
        {
            return Math.Round((money.MoneyAmount * USrates), MidpointRounding.ToEven);
        }


        public static string ConvertMoney(Money money)
        {
            string value;
            // Check for upper and lowr
            if (money.CurrencyUnit == "Euro")
            {
                value = $"US Conversion: ${EuroToUS(money)}\n" +
                        $"Yen Conversion: ¥{EuroToYen(money)}";
            }
            else if(money.CurrencyUnit == "US")
            {
                value = $"Euro Conversion: €{USToEuro(money)}\n" +
                        $"Yen Conversion: ¥{USToYen(money)}";
            }
            else if(money.CurrencyUnit == "Yen")
            {
                value = $"Euro Conversion: €{YenToEuro(money)}\n" +
                        $"US Conversion: ${YenToUS(money)}";
            }
            else
            {
                throw new ArgumentException("Invalid currency to convert!");
            }
            return value;
        }

        public static double AddMoney(Money money1, Money money2)
        {
            double value = 0.0;
          

            if (money1.CurrencyUnit == "Euro" && money2.CurrencyUnit == "Euro"
                || money1.CurrencyUnit == "US" && money2.CurrencyUnit == "US"
                || money1.CurrencyUnit == "Yen" && money2.CurrencyUnit == "Yen") 
            {
                value = money1.MoneyAmount + money2.MoneyAmount;
            }
            else if(money1.CurrencyUnit == "Euro" && money2.CurrencyUnit == "US")
            {
                value = money1.MoneyAmount + USToEuro(money2); 
            }
            else if (money1.CurrencyUnit == "Euro" && money2.CurrencyUnit == "Yen")
            {
                value = money1.MoneyAmount + YenToEuro(money2);
            }
            else if (money1.CurrencyUnit == "US" && money2.CurrencyUnit == "Euro")
            {
                value = money1.MoneyAmount + EuroToUS(money2);
            }
            else if (money1.CurrencyUnit == "US" && money2.CurrencyUnit == "Yen")
            {
                value = money1.MoneyAmount + YenToUS(money2);
            }
            else if (money1.CurrencyUnit == "Yen" && money2.CurrencyUnit == "US")
            {
                value = money1.MoneyAmount + USToYen(money2);
            }
            else if (money1.CurrencyUnit == "Yen" && money2.CurrencyUnit == "Euro")
            {
                value = money1.MoneyAmount + EuroToYen(money2);
            }
            return value;
        }
    }
}
