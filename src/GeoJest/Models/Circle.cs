using System;

namespace GeoJest.Models
{
    /// <summary>
    /// Represents a circle.
    /// </summary>
    public class Circle : Shape
    {
        private readonly double _radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is not positive.</exception>
        public Circle(double radius)
        {
            ValidateRadius(radius);
            _radius = radius;
        }

        /// <inheritdoc/>
        public override double GetArea() => Math.PI * _radius * _radius;

        /// <summary>
        /// Validates the radius of the circle.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is not positive.</exception>
        private void ValidateRadius(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive.", nameof(radius));
        }
    }
}