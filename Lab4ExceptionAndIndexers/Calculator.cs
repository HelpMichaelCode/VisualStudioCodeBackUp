using System;
namespace Lab4ExceptionAndIndexers
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public static double CalculateResult(double num1, double num2)
        {
            if(num2 <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return Math.Round(num1 / num2, 2, MidpointRounding.ToEven);
            }
        }

    }
}
