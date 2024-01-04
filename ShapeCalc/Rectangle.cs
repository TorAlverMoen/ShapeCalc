namespace ShapeCalc
{
    internal class Rectangle : Shapes
    {
        // A = l2, O = l2 * w2

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            Name = "Rectangle";
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculateCircumference()
        {
            return 2 * (Length + Width);
        }
    }
}
