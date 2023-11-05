using System;
using GeoJest.Factories.Abstractions;
using GeoJest.Models;

namespace GeoJest.Factories
{
    /// <summary>
    /// Factory for creating triangles.
    /// </summary>
    public class TriangleFactory : IShapeFactory
    {
        /// <summary>
        /// Creates a <see cref="Triangle"/> with the specified side lengths.
        /// </summary>
        /// <param name="dimensions">
        /// An array of dimensions where dimensions[0] is the length of side A,
        /// dimensions[1] is the length of side B, and dimensions[2] is the length of side C.
        /// </param>
        /// <returns>The created <see cref="Triangle"/>.</returns>
        /// <exception cref="ArgumentException">Thrown when the dimensions array does not contain exactly three values.</exception>
        public Shape Create(params double[] dimensions)
        {
            if (dimensions.Length != 3)
                throw new ArgumentException("A triangle must have three dimensions.", nameof(dimensions));

            return new Triangle(dimensions[0], dimensions[1], dimensions[2]);
        }
    }
}