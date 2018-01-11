using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.GeometryLib;

namespace Mindbox.GeometryLib.Tests
{
    [TestClass]
    public class GeomtryTests
    {
        [TestMethod]
        public void RightTriangleArea_InvalidParams_ThrowsExecption()
        {
            MyAssert.Throws<ArgumentOutOfRangeException>(() => Geometry.RightTriangleArea(0, 8, 6));
            MyAssert.Throws<ArgumentOutOfRangeException>(() => Geometry.RightTriangleArea(10, 8, 0));
            MyAssert.Throws<ArgumentOutOfRangeException>(() => Geometry.RightTriangleArea(10, -8, 6));
            MyAssert.Throws<ArgumentOutOfRangeException>(() => Geometry.RightTriangleArea(10, double.NaN, 6));

            MyAssert.Throws<ArgumentException>(() => Geometry.RightTriangleArea(9, 8, 6));
            MyAssert.Throws<ArgumentException>(() => Geometry.RightTriangleArea(9.999, 8, 6));
            MyAssert.Throws<ArgumentException>(() => Geometry.RightTriangleArea(10, 10, 200));
            MyAssert.Throws<ArgumentException>(() => Geometry.RightTriangleArea(10E+300, 10E+300, 10E+300));
            
        }
        [TestMethod]
        public void RightTriangleArea_ValidParams_TraingleArea()
        {
            Assert.AreEqual(24, Geometry.RightTriangleArea(8, 10, 6), 0);
            Assert.AreEqual(7.26, Geometry.RightTriangleArea(3.3, 4.4, 5.5), 0);
            //Assert.AreEqual(double.PositiveInfinity, Geometry.RightTriangleArea(double.MaxValue, 10, 20), 0);
        }
    }
}
