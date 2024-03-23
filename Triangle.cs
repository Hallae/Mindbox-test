using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    // Triangle class implementing IShape interface
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        // Constructor for Triangle with side lengths
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Accepts a visitor to calculate the area
        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }

        // Checks if the triangle is right-angled
        public bool IsRightAngled()
        {
            double aSquared = Math.Pow(SideA, 2);
            double bSquared = Math.Pow(SideB, 2);
            double cSquared = Math.Pow(SideC, 2);

            return aSquared + bSquared == cSquared || aSquared + cSquared == bSquared || bSquared + cSquared == aSquared;
        }
    }
}
