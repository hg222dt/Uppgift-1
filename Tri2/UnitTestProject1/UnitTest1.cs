using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangelUnitTest
    {
        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isIsoselesTest2()
        {
            Triangle tri2 = new Triangle(-1.0, -0.5, 2.0);
            Assert.IsFalse(tri2.isIsosceles());
        }

        [TestMethod]
        public void isIsoselesTest3()
        {
            Point a = new Point(1, 1);
            Point b = new Point(1, 2);
            Point c = new Point(2, 1);
            Triangle tri3 = new Triangle(a, b, c);
            Assert.IsTrue(tri3.isIsosceles());
        }

        [TestMethod]
        public void isIsoselesTest4()
        {
            Point a = new Point(1, 1);
            Point b = new Point(1, 2);
            Point c = new Point(2, 2);
            Triangle tri4 = new Triangle(a, b, c);
            Assert.IsTrue(tri4.isIsosceles());
        }

        [TestMethod]
        public void isIsoselesTest6()
        {
            double[] test = new double[3] { 1, 2, 5 };
            Triangle tri6 = new Triangle(test);
            Assert.IsFalse(tri6.isIsosceles());
        }

        [TestMethod]
        public void isIsoselesTest7()
        {
            Point[] pointArray = new Point[3];
            pointArray[0] = new Point(1, 1);
            pointArray[1] = new Point(1, 2);
            pointArray[2] = new Point(2, 1);
            Triangle tri7 = new Triangle(pointArray);
            Assert.IsTrue(tri7.isIsosceles());
        }

        
    }
}
