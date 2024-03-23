using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeAreaCalculator
{   // Rectangle class implementing IShape interface
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor for Rectangle with length and width parameters
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Accepts a visitor to calculate the area
        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
