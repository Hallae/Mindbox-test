using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    // AreaCalculator class implementing IShapeVisitor interface
    public class AreaCalculator : IShapeVisitor
    {
        public double Area { get; private set; }

        // Calculates the area of a circle
        public void Visit(Circle circle)
        {
            Area = Math.PI * Math.Pow(circle.Radius, 2);
        }

        // Calculates the area of a rectangle
        public void Visit(Rectangle rectangle)
        {
            Area = rectangle.Length * rectangle.Width;
        }

        // Calculates the area of a triangle using Heron's formula
        public void Visit(Triangle triangle)
        {
            double s = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            Area = Math.Sqrt(s * (s - triangle.SideA) * (s - triangle.SideB) * (s - triangle.SideC));
        }
    }
}
