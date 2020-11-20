using System;
namespace Lab3Interfaces
{
    public class SphereClass : IHasVolume
    {
        private readonly double _radius;
        public double Radius { get; set; }
        public string  SphereName{ get; set; }

        public SphereClass(double radiusInput, string sphereName)
        {
            if(radiusInput < 0)
            {
                _radius = 0.0;
            }
            else
            {
                _radius = radiusInput;
                Radius = _radius;
                SphereName = sphereName;
            }
        }

        
        public double CalculateVolume()
        {
            double result = Math.PI * Math.Pow(_radius, 3.0);
            return Math.Round(result, 2, MidpointRounding.ToEven);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\nRadius: {Radius}" +
                $"\nVolume: {CalculateVolume()}" +
                $"\nName of the sphere: {SphereName}";
        }

    }
}
