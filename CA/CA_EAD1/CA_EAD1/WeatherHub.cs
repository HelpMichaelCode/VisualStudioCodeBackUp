using System;
using System.Collections.Generic;

namespace CA_EAD1
{
    public class WeatherHub
    {
        List<DeviceReading> devices = new List<DeviceReading>();


        public void AddDevice(DeviceReading device)
        {
            Console.WriteLine("New device added for reading!");
            devices.Add(device);
        }

        public List<DeviceReading> ReturnDeviceSpecified(int id, int year, int month)
        {
            List<DeviceReading> matchingDeviceParameters = new List<DeviceReading>(); 
            for (int i = 0; i < devices.Count; i++)
            {
                if ((devices[i].ID == id) &&
                   (devices[i].Timestamp.Year == year) &&
                   (devices[i].Timestamp.Month == month))
                {
                    matchingDeviceParameters.Add(devices[i]);
                }
                else
                {
                    // throw new exception ArgumentException("No match for parameter values!")
                    // exception was breaking this code for some reason
                    Console.WriteLine("No match for parameter values!");
                }
            }

            return matchingDeviceParameters;
        }
    }
}
