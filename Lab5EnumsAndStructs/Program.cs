using System;
using System.Collections.Generic;

namespace Lab5EnumsAndStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Money Conversion Program");
            List<Money> list = new List<Money>
            {
                new Money(100, "Euro"),
                new Money(200, "US"),
                new Money(300, "Yen"),
                new Money(400, "Euro"),
                new Money(500, "US"),
                new Money(600, "Yen"),
                new Money(700, "US")
            };

            foreach (var item in list)
            {
                Console.WriteLine(Money.ConvertMoney(item));
               
            }

            Console.WriteLine(Money.AddMoney(list[0], list[1]));
        }
    }
}
