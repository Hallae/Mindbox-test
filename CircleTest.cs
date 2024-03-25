using NUnit.Framework;
using ShapeAreaCalculator;

namespace ShapeAreaCalculatorTests
{
    [TestFixture]
    public class CircleTests
    {
        // Test to verify that the GetArea method of the Circle class returns the correct area for a circle with a radius of 5.
        [Test]
        public void GetArea_WithRadius5_ReturnsCorrectArea()
        {
            // Arrange: Set up the test by creating a circle with a radius of 5.
            var circle = new Circle { Radius = 5 };

            // Act: Call the GetArea method on the circle.
            var result = circle.GetArea();

            // Assert: Verify that the result is equal to the expected area of a circle with a radius of 5.
            // The expected area is calculated as πr², where r = 5.
            var expectedArea = Math.PI * Math.Pow(5, 2);
            Assert.That(result, Is.EqualTo(expectedArea).Within(0.000000000000001));
        }
    }
}
