using System;

namespace ShapeAreaCalculator
{
    public interface IShape
    {
        double GetArea();
    }

    public class Program
    {
        public static void Main(string[] args)
        {  
            // Create a Circle object with a radius of 5
            Circle circle = new Circle { Radius = 5 };

            // Print the area of the circle
            Console.WriteLine($"Circle area: {circle.GetArea()}");

            // Create a Triangle object with sides of 3, 4, and 5 units
            Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

            // Print the area of the triangle
            Console.WriteLine($"Triangle area: {triangle.GetArea()}");

            // Print whether the triangle is right-angled
            Console.WriteLine($"Is triangle rectangular? {triangle.IsRectangular()}");
        }
    }
}
