using System;
using Xunit;
using GeoJest.Factories;

namespace GeoJest.Tests.Models
{
    public class CircleTests
    {
        private readonly CircleFactory _circleFactory = new CircleFactory();

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        public void GetArea_GivenValidRadius_ReturnsExpectedArea(double radius, double expectedArea)
        {
            var circle = _circleFactory.Create(radius);
            var actualArea = circle.GetArea();
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_GivenNonPositiveRadius_ThrowsArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => _circleFactory.Create(radius));
        }
    }
}