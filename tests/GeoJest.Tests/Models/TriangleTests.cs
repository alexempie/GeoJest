using Xunit;
using GeoJest.Factories;
using GeoJest.Abstractions;

namespace GeoJest.Tests.Models
{
    public class TriangleTests
    {
        private readonly TriangleFactory _triangleFactory = new TriangleFactory();

        [Theory]
        [InlineData(3, 4, 5, 6)] // right-angled triangle
        [InlineData(5, 12, 13, 30)] // right-angled triangle
        public void GetArea_GivenValidSides_ReturnsExpectedArea(double a, double b, double c, double expectedArea)
        {
            var triangle = _triangleFactory.Create(a, b, c);
            var actualArea = triangle.GetArea();
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Theory]
        [InlineData(3, 4, 5, true)] // right-angled triangle
        [InlineData(5, 12, 13, true)] // right-angled triangle
        [InlineData(3, 3, 3, false)] // equilateral triangle
        public void IsRightAngled_GivenValidSides_ReturnsExpectedResult(double a, double b, double c, bool expectedResult)
        {
            var triangle = _triangleFactory.Create(a, b, c) as IRightAngleCheckable;
            Assert.NotNull(triangle);
            var actualResult = triangle.HasRightAngle();
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-1, -1, -1)]
        [InlineData(1, 2, 3)]
        public void Constructor_GivenInvalidSides_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => _triangleFactory.Create(a, b, c));
        }
    }
}