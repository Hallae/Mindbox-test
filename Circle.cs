using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
     // Circle class implementing IShape interface
    public class Circle : IShape
    {
        public double Radius { get; set; }

        // Constructor for Circle with radius parameter
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Accepts a visitor to calculate the area
        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
