using System;

namespace ShapeAreaCalculator
{
   

    class Program
    {
        static void Main(string[] args)
        {
            //  the Circle, Rectangle, and Triangle classes
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4, 5);

            // Create an instance of the AreaCalculator
            AreaCalculator areaCalculator = new AreaCalculator();

            // Calculate and print the area of the circle
            circle.Accept(areaCalculator);
            Console.WriteLine($"Area of the circle: {areaCalculator.Area}");

            // Calculate and print the area of the rectangle
            rectangle.Accept(areaCalculator);
            Console.WriteLine($"Area of the rectangle: {areaCalculator.Area}");

            // Calculate and print the area of the triangle
            triangle.Accept(areaCalculator);
            Console.WriteLine($"Area of the triangle: {areaCalculator.Area}");

            // Check if the triangle is right-angled and print the result
            Console.WriteLine($"Is the triangle right-angled? {triangle.IsRightAngled()}");
        }
    }
}
