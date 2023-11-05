using GeoJest.Abstractions;

namespace GeoJest.Models
{
    /// <summary>
    /// Provides an abstraction for a geometric shape.
    /// </summary>
    public abstract class Shape : IAreaMeasurable
    {
        /// <summary>
        /// Calculates the area of the geometric shape.
        /// </summary>
        /// <returns>The area of the geometric shape.</returns>
        public abstract double GetArea();
    }
}