using System;
using System.Collections.Generic;

namespace Lab2Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCollection = new List<Shape>()
            {
                new Line(6,5,1,2,"Blue"),
                new Circle(3,4,5,"Yellow"),
            };

            Vertex newVertex = new Vertex(6,6);


            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
                item.Translate(newVertex);
            }
        }
    }
}
