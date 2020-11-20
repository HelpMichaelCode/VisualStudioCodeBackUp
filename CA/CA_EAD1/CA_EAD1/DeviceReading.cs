using System;
namespace CA_EAD1
{
    public class DeviceReading
    {
        // Auto implemented properties
        public int ID { get; set; }
        public DateTime Timestamp { get; set; }

        // Non-default contructor
        public DeviceReading(int id, DateTime timeStamp)
        {
            ID = id;
            Timestamp = timeStamp;
        }

        // Overriding ToString() from System.object class
        public override string ToString()
        {
            return $"Device ID: {ID}\n" +
                   $"Reading taken at: {Timestamp}";
        }
    }
}
