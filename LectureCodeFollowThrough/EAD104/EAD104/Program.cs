using System;

namespace EAD104
{
    class Program
    {
        public interface IDrawable
        {
            void Draw();
        }

        class Circle : IDrawable
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Radius { get; set; }

            public void Draw() => Console.WriteLine($"Drawing a Circle at ({X}, {Y}), Radius {Radius}");

            public override string ToString()
            {
                return base.ToString();
            }
        }
        
        static void Main(string[] args)
        {
            Circle c = new Circle
            {
                X = 10,
                Y = 20,
                Radius = 10
            };

            c.Draw();
        }
    }
}
