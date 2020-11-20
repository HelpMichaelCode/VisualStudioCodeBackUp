using System;
namespace Lab2Polymorphism
{
    public abstract class Shape
    {
        // Property
        public string Colour { get; set; }

        // Default Constructor
        public Shape()
        {
        }

        // Overloaded Constructor
        public Shape(string colorInput)
        {
            Colour = colorInput;
        }

        // Overrided method
        public override string ToString()
        {
            return $"The colour of this Circle: {Colour}";
        }

        public abstract void Translate(Vertex vertexObj);
    }
}
