using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeometryShape;

namespace ShapeTest
{
    public class ShapeTests
    {
        [Theory]
        [InlineData(-5,5)]
        [InlineData(0,5)]
        public void WrongArgumentsRectangleNotCreated(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }
        [Theory]
        [InlineData(-5,5,5)]
        [InlineData(0,5,5)]
        [InlineData(15,5,5)]
        public void WrongArgumentsTriangleNotCreated(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
        [Fact]
        public void RectangleAreaCalculateTest()
        {
            const double width = 5;
            const double height = 5;

            double expectedArea = width * height;

            Rectangle rectangle = new(width, height);

            Assert.Equal(expectedArea, rectangle.Area());
        }
        [Fact]
        public void RectanglePerimeterCalculateTest()
        {
            const double width = 5;
            const double height = 5;

            double expectedPerimeter = (width * 2) + (height * 2);

            Rectangle rectangle = new(width, height);

            Assert.Equal(expectedPerimeter, rectangle.Perimeter());
        }
        [Fact]
        public void TriangleAreaCalculateTest()
        {
            const double a = 5;
            const double b = 5;
            const double c = 5;

            double p = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Triangle triangle = new(a, b, c);

            Assert.Equal(expectedArea, triangle.Area());
        }
        [Fact]
        public void TrianglePerimeterCalculateTestFailedOnPurpose()
        {
            const double a = 5;
            const double b = 5;
            const double c = 5;

            double expectedPerimeter = a * b * c;

            Triangle triangle = new(a, b, c);

            Assert.Equal(expectedPerimeter, triangle.Perimeter());
        }
    }
}
