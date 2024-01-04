using System;
using System.Collections.Generic;

namespace ShapeCalc
{
    internal class Program
    {
        static void DisplayShapeInfo()
        {
            List<Shapes> shapes = new List<Shapes>
            {
                new Circle(10),
                new Rectangle(8, 26),
                new Square(10)
            };

            foreach (Shapes shape in shapes)
            {
                Console.WriteLine($"{shape.Name} area is {shape.CalculateArea()}");
                Console.WriteLine($"{shape.Name} circumference is {shape.CalculateCircumference()}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            DisplayShapeInfo();
        }
    }
}
