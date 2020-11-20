namespace Lab1AbstractClass
{
    public abstract class ThreeDShape
    {
        private string _shapeType;
        public readonly string shapeType;

        public ThreeDShape()
        {
        }

        public ThreeDShape(string shapeTypeIn)
        {
            _shapeType = shapeTypeIn;
            shapeType = _shapeType;
        }

        public override string ToString()
        {
            return $"Shape: {shapeType}";
        }

        public abstract double GetVolume();
    }
}
