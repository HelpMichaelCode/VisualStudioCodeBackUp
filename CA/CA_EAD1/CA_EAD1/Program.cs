using System;

namespace CA_EAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing DeviceReading class 
            //DeviceReading deviceRead = new DeviceReading(1, DateTime.Now);
            //Console.WriteLine(deviceRead);

            // Testing HygrometerReading class for invalid values
            // HygrometerReading testDevice1Humidity = new HygrometerReading(100.00, 45.32, 1);
            // HygrometerReading testDevice1Temperature = new HygrometerReading(21.99, 99.99, 1);

            // Checking if add function works
            //HygrometerReading device = new HygrometerReading(21.00, 45.00, 1, DateTime.Now);
            //WeatherHub weatherTracker = new WeatherHub();
            //weatherTracker.AddDevice(device);

            // Testing the actual coded program
            HygrometerReading device1 = new HygrometerReading(21.00, 35.00, 1);
            HygrometerReading device2 = new HygrometerReading(23.00, 40.00, 2, new DateTime(2000,5,26));
            HygrometerReading device3 = new HygrometerReading(24.00, 41.00, 3, new DateTime(2001,7,27));
            
            WeatherHub weatherTracker = new WeatherHub();
            weatherTracker.AddDevice(device1);
            weatherTracker.AddDevice(device2);
            weatherTracker.AddDevice(device3);

            foreach (var item in weatherTracker.ReturnDeviceSpecified(3,2001,7))
            {
                Console.WriteLine(item);
            }
        }
    }
}
