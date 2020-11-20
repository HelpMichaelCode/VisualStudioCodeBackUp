using System;
using System.Collections.Generic;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("Tesla", "Model 3", "133-D-145", 2300),
                new Car("Toyota", "Prius", "131-D-131", 950),
                new Car("Lamborghini", "Diablo", "1-D-199", 3000),
                new Car("Mazda", "CX 5", "199-D-145", 1500),
                new Car("Opel", "Corsa", "132-D-141", 1000),
                new Car("Tesla", "Model X", "134-D-150", 9000),
                new Car("Mazda", "RX 8", "198-D-150", 400)
            };

            Fleet fleet = new Fleet("Euphoria");

            foreach (var item in cars)
            {
                fleet.AddCar(item);
            }

            Console.WriteLine(fleet);
            //foreach (var item in fleet.CarsInAscendingOrder())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("------------");
            //}

            //Console.WriteLine("All Mazda Models");
            //foreach (var item in fleet.ListAllMazdaModels())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("------------");
            //}

            //Console.WriteLine("All cars in descending order");
            //foreach (var item in fleet.CarsInDescendingOrder())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("------------");  
            //}

            //Console.WriteLine("All cars above 1600cc");
            //foreach (var item in fleet.CarsAbove1600cc())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("------------");
            //}

            //Console.WriteLine($"Number of cars whose engine is less than or equals to 1600cc: " +
            //                  $"{fleet.CarsLessThanOrEqualsTo1600cc()}");
        }
    }
}
