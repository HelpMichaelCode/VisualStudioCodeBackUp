using System;
using System.Collections.Generic;

namespace Lab4ExceptionAndIndexers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculator Program

            //double input1, input2;

            //Console.Write("Enter in first input: ");
            //input1 = Double.Parse(Console.ReadLine());

            //Console.Write("Enter in second input: ");
            //input2 = Double.Parse(Console.ReadLine());

            //if(input1.GetType() != typeof(double) || input2.GetType() != typeof(double))
            //{
            //    throw new FormatException();
            //}
            //else
            //{
            //    Console.WriteLine($"Result is: {Calculator.CalculateResult(input1, input2)}");
            //}


            // ModuleCAResults

            try
            {
                ModuleCAResults test = new ModuleCAResults
                {
                    ModuleName = "Software Development",
                    Credits = 99,
                    StudentName = "Michael"
                };

                test["CA1"] = 99;
                test["CA2"] = 101;
                test["CA3"] = 102;
                test["CA4"] = 109;

                Console.WriteLine(test.ToString());
                Console.WriteLine("-----------------");
                Console.WriteLine(test["CA1"]);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message: " + e);
            }

        }
    }
}
