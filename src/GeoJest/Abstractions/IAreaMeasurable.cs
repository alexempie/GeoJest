namespace GeoJest.Abstractions
{
    /// <summary>
    /// Defines a contract for geometric shapes that have measurable areas.
    /// </summary>
    public interface IAreaMeasurable
    {
        /// <summary>
        /// Calculates and returns the area of the geometric shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        double GetArea();
    }
}