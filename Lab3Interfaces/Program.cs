using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Interfaces
{
    class Program
    {
        static void Main(string[] args)
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

            string test = "CA230";

           // Console.WriteLine(test[2..]);

            var strings = new string[] { "7", "13", "8", "12", "10", "11", "14" };
            var list = Array.ConvertAll(strings, s => Int32.Parse(s)).OrderBy(i => i);
            var result = Enumerable.Range(list.Min(), list.Count()).Except(list).First(); // 9
            Console.WriteLine(result);
        }
    }
}
