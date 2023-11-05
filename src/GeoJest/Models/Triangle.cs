using System;
using GeoJest.Abstractions;

namespace GeoJest.Models
{
    /// <summary>
    /// Class representing a triangle.
    /// </summary>
    public class Triangle : Shape, IRightAngleCheckable
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sideA">Length of side A.</param>
        /// <param name="sideB">Length of side B.</param>
        /// <param name="sideC">Length of side C.</param>
        /// <exception cref="ArgumentException">Thrown when the sides are not positive or do not form a triangle.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateSides(sideA, sideB, sideC);
            
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            var semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(
                semiPerimeter 
                * (semiPerimeter - _sideA) 
                * (semiPerimeter - _sideB) 
                * (semiPerimeter - _sideC)
            );
        }

        /// <inheritdoc/>
        public bool HasRightAngle()
        {
            var sidesSquared = new[] { _sideA * _sideA, _sideB * _sideB, _sideC * _sideC };
            Array.Sort(sidesSquared);

            return Math.Abs(sidesSquared[2] - (sidesSquared[0] + sidesSquared[1])) < 1E-10;
        }

        /// <summary>
        /// Validates the sides of the triangle.
        /// </summary>
        /// <param name="sideA">Length of side A.</param>
        /// <param name="sideB">Length of side B.</param>
        /// <param name="sideC">Length of side C.</param>
        /// <exception cref="ArgumentException">Thrown when the sides are not positive or do not form a triangle.</exception>
        private void ValidateSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Sides must be positive.");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Sides do not form a triangle.");
        }
    }
}