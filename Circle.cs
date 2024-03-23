using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            // Calculate the area of the circle using the formula πr²
            return Math.PI * Radius * Radius;
        }
    }
}
