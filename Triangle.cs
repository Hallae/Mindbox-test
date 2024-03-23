using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Triangle : IShape
    {
        // Properties to store the lengths of the sides of the triangle
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double GetArea()
        {
            // Calculate the semi-perimeter of the triangle
            double semiPerimeter = (Side1 + Side2 + Side3) / 2;

            // Use Heron's formula to calculate the area of the triangle
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }

        // Method to check if the triangle is right-angled
        public bool IsRectangular()
        {
            // Check if the square of the longest side is equal to the sum of the squares of the other two sides
            // This is based on the Pythagorean theorem
            double maxSide = Math.Max(Math.Max(Side1, Side2), Side3);
            return Math.Pow(maxSide, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2) + Math.Pow(Side3, 2) - 2 * maxSide * (Side1 + Side2 + Side3);
        }
    }
}
