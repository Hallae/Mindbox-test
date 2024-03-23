using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    
    // Interface for shapes that can accept a visitor for area calculation
    public interface IShape
    {
        // Accepts a visitor to calculate the area
        void Accept(IShapeVisitor visitor);
    }
}
