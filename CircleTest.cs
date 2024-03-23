using NUnit.Framework;
using ShapeAreaCalculator;

namespace ShapeAreaCalculatorTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle { Radius = 5 };

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.That(result, Is.EqualTo(78.53981633974483).Within(0.000000000000001)); // πr² for r=5
        }
    }
}
