using System;
namespace LinqLab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int EngineSize { get; set; }

        public Car(string carMake, string carModel, string carRegistration, int carEngineSize)
        {
            Make = carMake;
            Model = carModel;
            Registration = carRegistration;
            EngineSize = carEngineSize;
        }

        public override string ToString()
        {
            return $"Car Make: {Make}\n" +
                   $"Car Model: {Model}\n" +
                   $"Car Registration: {Registration}\n" +
                   $"Car Engine Size: {EngineSize}cc"; 
        }
    }
}
