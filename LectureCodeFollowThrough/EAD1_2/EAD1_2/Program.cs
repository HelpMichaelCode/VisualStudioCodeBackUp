using System;
using EAD1_2;

namespace Garage
{
    public class Car : Object
    {
        private string make, model, registration;

        public Car(string make, string model, string registration)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
        }

        public Car() :this("", "", "")
        {
        }

        ~Car()
        {
            Console.WriteLine("{0} destructured", this.registration);
        }

        public override string ToString() => $"Make: {make}\nModel: {model}\nRegistration: {registration}";
        
    }

    //public class Test
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("Car Class");
    //        Car c = new Car("Mercedes","GLA 200","2020");
    //        Console.WriteLine(c);


    //        Console.WriteLine("-------------------");
    //        Console.WriteLine("Person Class");
    //        // new Person() object -> stored in heap.
    //        // Person p -> is a reference value of the object stored in heap
    //        // which is -> new Person();
    //        Person p = new Person
    //        {
    //            Name = "Michael",
    //            Dob = new DateTime(1999, 5, 26)
    //        };
    //        Console.WriteLine(p);
    //    }
    //}
}
