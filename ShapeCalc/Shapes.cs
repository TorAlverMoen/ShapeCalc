namespace ShapeCalc
{
    internal class Shapes
    {
        public string Name { get; set; }

        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculateCircumference()
        {
            return 0;
        }
    }
}
