using System;
using System.Collections.Generic;

namespace EAD1_2
{
    public class Dog
    {
        // auto implemented property
        public string Name { get; set; }
           

        public Dog(string name)
        {
            this.Name = name;
        }

        // Default Constructor 
        public Dog()
        {
        }
        public override string ToString()
        {
            return $"Name of this dog is: {Name}";
        }
    }

    public class Test
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>
            {
              new Dog("Milo"),
              new Dog("Mika"),
              new Dog("Neptune")
            };

            foreach (var item in dogs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
