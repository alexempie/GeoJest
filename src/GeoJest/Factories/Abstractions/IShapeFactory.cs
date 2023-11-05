using GeoJest.Models;

namespace GeoJest.Factories.Abstractions
{
    /// <summary>
    /// Defines a contract for factories that create geometric shapes.
    /// </summary>
    public interface IShapeFactory
    {
        /// <summary>
        /// Creates a geometric shape with the specified dimensions.
        /// </summary>
        /// <param name="dimensions">
        /// The dimensions required to create the shape. The meaning of each dimension
        /// depends on the specific shape being created.
        /// </param>
        /// <returns>The created shape.</returns>
        Shape Create(params double[] dimensions);
    }
}