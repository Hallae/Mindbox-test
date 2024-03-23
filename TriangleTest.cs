using NUnit.Framework;
using ShapeAreaCalculator;

namespace ShapeAreaCalculatorTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

            // Act
            var result = triangle.GetArea();

            // Assert
            Assert.That(result, Is.EqualTo(6).Within(0.000000000000001)); // Heron's formula for sides 3, 4, 5
        }

        [Test]
        public void IsRectangular_ReturnsTrueForRightAngledTriangle()
        {
            // Arrange
            var triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

            // Act
            var result = triangle.IsRectangular();

            // Assert
            Assert.That(result, Is.True); // 3, 4, 5 form a right-angled triangle
        }

        [Test]
        public void IsRectangular_ReturnsFalseForNonRightAngledTriangle()
        {
            // Arrange
            var triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 6 };

            // Act
            var result = triangle.IsRectangular();

            // Assert
            Assert.That(result, Is.False); // 3, 4, 6 do not form a right-angled triangle
        }
    }
}
