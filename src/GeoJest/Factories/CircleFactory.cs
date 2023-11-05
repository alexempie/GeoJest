using System;
using GeoJest.Factories.Abstractions;
using GeoJest.Models;

namespace GeoJest.Factories
{
    /// <summary>
    /// Provides a factory for creating instances of the <see cref="Circle"/> class.
    /// </summary>
    public class CircleFactory : IShapeFactory
    {
        /// <summary>
        /// Creates a <see cref="Circle"/> instance with the specified dimensions.
        /// </summary>
        /// <param name="dimensions">
        /// The dimensions required to create the circle. 
        /// Only the first value in the array is used as the radius of the circle.
        /// </param>
        /// <returns>The created <see cref="Circle"/> instance.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when more than one dimension is provided.
        /// </exception>
        public Shape Create(params double[] dimensions)
        {
            if (dimensions.Length != 1)
                throw new ArgumentException("Circle requires exactly one dimension for the radius.", nameof(dimensions));

            return new Circle(dimensions[0]);
        }
    }
}