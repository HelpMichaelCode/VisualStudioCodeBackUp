using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    public class Fleet
    {
        public string FleetName { get; set; }
        List<Car> cars;


        public Fleet(string nameOfFleet)
        {
            FleetName = nameOfFleet;
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public IEnumerable<Car> CarsInAscendingOrder()
        {
            return cars.OrderBy(c => c.Registration);
        }

        public List<Car> ListAllMazdaModels()
        {
            
            return cars.FindAll(c => c.Make.Contains("Mazda"));
        }

        public IEnumerable<Car> CarsInDescendingOrder()
        {
            return cars.OrderByDescending(c => c.EngineSize);
        }

        public List<Car> CarsAbove1600cc()
        {
            return cars.FindAll(c => c.EngineSize > 1600);
        }

        public int CarsLessThanOrEqualsTo1600cc()
        {
            return cars.Count(c => c.EngineSize <= 1600);
        }

        public override string ToString()
        {
            return $"Fleet Name: {FleetName}";
        }
    }
}
