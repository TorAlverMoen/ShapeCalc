using System;

namespace ShapeCalc
{
    internal class Circle : Shapes
    {
        // A = πr2, O = 2πr

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            Name = "Circle";
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
