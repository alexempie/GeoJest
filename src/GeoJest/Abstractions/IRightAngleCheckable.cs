namespace GeoJest.Abstractions
{
    /// <summary>
    /// Defines a contract for geometric shapes that can verify the presence of a right angle.
    /// </summary>
    public interface IRightAngleCheckable
    {
        /// <summary>
        /// Determines whether the shape has a right angle.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the shape has a right angle; otherwise, <c>false</c>.
        /// </returns>
        bool HasRightAngle();
    }
}