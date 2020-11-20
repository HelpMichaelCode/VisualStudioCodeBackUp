using System;
namespace Lab2Polymorphism
{
    public class Line : Shape
    {
        // Properties
        public Vertex MyVertex1 { get; set; }
        public Vertex MyVertex2 { get; set; }

        // Default Constructor
        public Line()
        {
        }

        // Overloaded Constructor
        public Line(int inputV1, int inputV2, int inputV3, int inputV4, string colour) : base(colour)
        {
            // End point in the graph
            MyVertex1 = new Vertex(inputV3, inputV4);
            MyVertex2 = new Vertex(inputV1, inputV2); 
        }

        public override string ToString()
        {
            return $"{base.ToString()}, it's original vertices are v1 = {MyVertex1} & v2 = {MyVertex2}";
        }
        // vertexObj = newVertex -> X= 6, Y = 6
        public override void Translate(Vertex vertexObj)
        {
            int newPosition1 = vertexObj.xCord + (MyVertex1.xCord);
            MyVertex1.xCord = newPosition1; 
            int newPosition2 = vertexObj.yCord + (MyVertex1.yCord);
            MyVertex1.yCord = newPosition2;
            int newPosition3 = vertexObj.xCord + (MyVertex2.xCord);
            MyVertex2.xCord = newPosition3;
            int newPosition4 = vertexObj.yCord + (MyVertex2.yCord);
            MyVertex2.yCord = newPosition4;

            Console.WriteLine($"New Values: {this}");
        }
    }
}
