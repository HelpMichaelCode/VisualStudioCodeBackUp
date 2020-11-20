using System;
using System.Collections.Generic;

namespace Lab1AbstractClass
{
    public class MainClass
    {
       
        public static void Main(string[] args)
        {
            var spheres = new List<SphereClass>();
            spheres.Add(new SphereClass(1.0, "This is sphere 1"));
            spheres.Add(new SphereClass(2.0, "This is sphere 2"));
            spheres.Add(new SphereClass(3.0, "This is sphere 3"));
            spheres.Add(new SphereClass(4.0, "This is sphere 4"));

            foreach (var item in spheres)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("--------------------");
            }
        }
        
    }
}
