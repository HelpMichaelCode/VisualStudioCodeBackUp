using System;
namespace CA_EAD1
{
    public class HygrometerReading : DeviceReading
    {
        // private field
        private double humidity;
        // Property for humidity
        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                // Checking if passed in value is within the range
                if(value >= 20 && value <= 90)
                {
                    humidity = value;
                }
                else
                {
                    // Throwing an exception
                    throw new ArgumentException("Humidity value is not within the range!");
                }
            }
        }

        // private field
        private double temperature;
        // Proper for temperature
        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                // Checking if passed in value is within the range
                if (value >= -20 && value <= 50)
                {
                    temperature = value;
                }
                else
                {
                    // Throwing an exception
                    throw new ArgumentException("Temperature value is not within the range!");
                }
            }
        }

        public HygrometerReading(double humidity, double temperature, int deviceID, DateTime timeStamp) : base (deviceID, timeStamp)
        {
            // Using property set accessor to set values for humidity and temperature fields
            Humidity = humidity;
            Temperature = temperature;
        }

        // Constructor chaining
        public HygrometerReading(double humidity, double temperature, int deviceID) : this(humidity, temperature, deviceID, DateTime.Now)
        { }

        // Overriding ToString() from System.object class
        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Humidity: {Humidity}%\n" +
                   $"Temperature: {Temperature}°C"; // base.ToString() calls the ToString() in the base class
        }
    }
}
