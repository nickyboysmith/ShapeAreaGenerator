using System;
using Xunit;
using ShapeAreaGenerator;

namespace ShapeAreaGenerator.Tests
{
    public class ShapeAreaGeneratorTests
    {

        // Positive Tests
        [Fact]

        public void SquareLength10ShouldReturn100()
        {
            // Arrange
            const float expected = 100;
            // Act
            Square sq = new Square(10);
            sq.CalculateArea();
            float actual = sq.Area;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RectangleWidth20Length10ShouldReturn200()
        {
            // Arrange
            const float expected = 200;
            // Act
            Rectangle rec = new Rectangle(20, 10);
            rec.CalculateArea();
            float actual = rec.Area;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleWidth15Height10ShouldReturn75()
        {
            // Arrange
            const float expected = 75;
            // Act
            Triangle tri = new Triangle(15, 10);
            tri.CalculateArea();
            float actual = tri.Area;
            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CircleRadius15ShouldReturn706Point85834()
        {
            // Arrange
            const float expected = 706.85834F;
            // Act
            Circle cir = new Circle(15);
            cir.CalculateArea();
            float actual = cir.Area;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SphereRadius20ShouldReturn5026Point5483()
        {
            // Arrange
            const float expected = 5026.5483F;
            // Act
            Sphere sph = new Sphere(20);
            sph.CalculateArea();
            float actual = sph.Area;
            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
