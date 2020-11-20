using System;
namespace Lab2Polymorphism
{
    public class Circle : Shape
    {
        // Properties
        public Vertex MyVertex { get; set; }
        public int Radius { get; set; }

        // Default Constructor
        public Circle()
        {
        }

        // Overloaded Constructor
        public Circle(int inputV1, int inputV2, int inputRadius, string inputColour) : base(inputColour)
        {
            //MyVertex.xCord = inputV1;
            //MyVertex.yCord = inputV2;

            // Start point in the graph
            MyVertex = new Vertex(inputV1, inputV2);
            Radius = inputRadius;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Origin (V1, V2): ({MyVertex.xCord}, {MyVertex.yCord}\n" +
                $"Circle radius: {Radius}\n" +
                $"Colour";
        }

        public override void Translate(Vertex vertexObj)
        {
            Console.WriteLine($"New vertices position for Circle -> v1 = {MyVertex.xCord + (vertexObj.xCord)} & " +
                $"v2 = {MyVertex.yCord + (vertexObj.yCord)}");
        }
    }
}
