using System;

namespace ShapeCalc
{
    internal class Square : Shapes
    {
        // A = 2s, O = 4s

        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
            Name = "Square";
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override double CalculateCircumference()
        {
            return 4 * Side;
        }
    }
}
