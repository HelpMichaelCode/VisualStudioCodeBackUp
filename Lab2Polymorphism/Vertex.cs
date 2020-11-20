using System;
namespace Lab2Polymorphism
{
    public class Vertex
    {
        
        // Properties
        public int xCord { get; set; }
        public int yCord { get; set; }

        // Default constructor
        public Vertex(int xCordInput, int yCordInput)
        {
            xCord = xCordInput;
            yCord = yCordInput;
        }

        public override string ToString()
        {
            return $"X = {xCord}, Y = {yCord}";
        }
    }   
}

