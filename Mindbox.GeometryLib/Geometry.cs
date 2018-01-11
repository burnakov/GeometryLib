using System;
using System.Linq;

[assembly: CLSCompliant(true)]
namespace Mindbox.GeometryLib
{
    public static class Geometry
    {
        /// <summary>
        /// Calculates the area of ​​a right triangle given by three lengths of its sides.
        /// </summary>
        /// <param name="sideA">First traingle side.</param>
        /// <param name="sideB">Second traingle side.</param>
        /// <param name="sideC">Third traingle side.</param>
        /// <returns>Right traingle area.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws if one or more traingle side is NaN, or less or equal to zero.</exception>
        /// <exception cref="ArgumentException">Throws if traingle is not right-angeled.</exception>
        public static double RightTriangleArea(double sideA, double sideB, double sideC)
        {
            if (ArgumentValidation.IsNan(sideA, sideB, sideC))
                throw new ArgumentOutOfRangeException("Function arguments can not be NaN.");
            if (!ArgumentValidation.IsGreaterThenZero(sideA, sideB, sideC))
                throw new ArgumentOutOfRangeException("Function arguments must be gteater then zero.");
            
            if (IsRightTriangle(sideA, sideB, sideC))
            {
                double[] sides = { sideA, sideB, sideC };
                double hypotenuse = sides.Max();
                double[] catheti = sides.Where(cathetus => cathetus != hypotenuse).ToArray();
                double triangleArea = catheti[0] * catheti[1] / 2;
                return triangleArea;
            }
            else
                throw new ArgumentException("Function arguments do not represent a right triangle.");
        }
        /// <summary>
        /// Returns a value indicating wether the triangle is right-angeled.
        /// </summary>
        /// <param name="sideA">First traingle side.</param>
        /// <param name="sideB">Second traingle side.</param>
        /// <param name="sideC">Third traingle side.</param>
        private static bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            double[] sides = { sideA, sideB, sideC };
            // Hypotenuse in right trangle allways greater then its catheti
            double hypotenuse = sides.Max();
            double countMaxLenght = sides.Count(side => side == hypotenuse);
            if (countMaxLenght == 1)
            {
                double[] catheti = sides.Where(side => side < hypotenuse).ToArray();
                // Trangle is right-angeled if square of the hypotenuse is equal to the sum of the squares of the other two sides
                return (hypotenuse * hypotenuse == catheti[0] * catheti[0] + catheti[1] * catheti[1]);
            }
            return false;
        }
    }
}
