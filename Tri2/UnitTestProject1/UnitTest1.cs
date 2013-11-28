using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangelUnitTest
    {

        ////Test to pass, av metod för likbenta trianglar, samt test av kontruktor med 3 st argument i form av double.

        //[TestMethod]
        //public void isIsoscelesTest()
        //{
        //    Triangle tri = new Triangle(1.0, 0.5, 1.0);
        //    Assert.IsTrue(tri.isIsosceles());
        //}

        ////Test to fail, på metod för likbenta trianglar, med argument som inte skapar en likbent triangel.

        //[TestMethod]
        //public void isIsoselesTest2()
        //{
        //    Triangle tri = new Triangle(1.0, 0.5, 3.0);
        //    Assert.IsFalse(tri.isIsosceles());
        //}

        ////Test to pass, på metod för likbenta trianglar, genom konstruktor som tar emot tre argument i form av struct.

        //[TestMethod]
        //public void isIsoselesTest3()
        //{
        //    Point a = new Point(1, 1);
        //    Point b = new Point(1, 2);
        //    Point c = new Point(2, 1);
        //    Triangle tri = new Triangle(a, b, c);
        //    Assert.IsTrue(tri.isIsosceles());
        //}

        ////Test to pass, på metod för likbenta trianglar, genom konstruktor som tar emot tre argument i form av 3 st struct.

        //[TestMethod]
        //public void isIsoselesTest4()
        //{
        //    Point a = new Point(1, 1);
        //    Point b = new Point(1, 2);
        //    Point c = new Point(2, 2);
        //    Triangle tri = new Triangle(a, b, c);
        //    Assert.IsTrue(tri.isIsosceles());
        //}

        ////Test to fail, på metod för likbenta trianglar, genom konstruktor som tar emot tre argument i form av en array med 3 st argument i form av double.

        //[TestMethod]
        //public void isIsoselesTest5()
        //{
        //    double[] test = new double[3] { 1, 2, 5 };
        //    Triangle tri = new Triangle(test);
        //    Assert.IsFalse(tri.isIsosceles());
        //}

        ////Test to pass, på metod för likbenta trianglar, genom konstruktor som tar emot tre argument i form av en array med 3 st argument i form av struct.

        //[TestMethod]
        //public void isIsoselesTest6()
        //{
        //    Point[] pointArray = new Point[3];
        //    pointArray[0] = new Point(1, 1);
        //    pointArray[1] = new Point(1, 2);
        //    pointArray[2] = new Point(2, 1);
        //    Triangle tri = new Triangle(pointArray);
        //    Assert.IsTrue(tri.isIsosceles());
        //}

        ////Test to pass, på metod för liksidiga trianglar, genom konstruktor som tar emot tre argument i form av double.

        //[TestMethod]
        //public void isEquilateralTest1()
        //{
        //    Triangle tri = new Triangle(1.0, 1.0, 1.0);
        //    Assert.IsTrue(tri.isEquilateral());
        //}

        //////Test to pass, på metod för liksidiga trianglar, genom konstruktor som tar emot tre argument i form av double. Ett av argumenten är negativt.

        ////[TestMethod]
        ////public void isEquilateralTest2()
        ////{
        ////    Triangle tri = new Triangle(-1.0, 1.0, 1.0);
        ////    Assert.IsFalse(tri.isEquilateral());
        ////}

        ////Test to pass, på metod för liksidiga trianglar, genom konstruktor som tar emot tre argument i form av double. Två av argumenten är negativa.

        ////[TestMethod]
        ////public void isEquilateralTest3()
        ////{
        ////    Triangle tri = new Triangle(-1.0, -1.0, 1.0);
        ////    Assert.IsFalse(tri.isEquilateral());
        ////}

        ////Test to pass, på metod för liksidiga trianglar, genom konstruktor som tar emot tre argument i form av double. Tre av argumenten är negativa.

        ////[TestMethod]
        ////public void isEquilateralTest4()
        ////{
        ////    Triangle tri = new Triangle(-1.0, -1.0, -1.0);
        ////    Assert.IsTrue(tri.isEquilateral());
        ////}
        
        ////Test to fail, på metod som kontrollerar om triangeln har tre sidor som är olika från varandra. 
        ////Detta genom konstruktor som tar emot tre argument i form av double. Argumenten är av samma värde.

        //[TestMethod]
        //public void isScaleneTest1()
        //{
        //    Triangle tri = new Triangle(1.0, 1.0, 1.0);
        //    Assert.IsFalse(tri.isScalene());
        //}

        ////Test to pass, på metod som kontrollerar om triangeln har tre sidor som är olika från varandra. 
        ////Detta genom konstruktor som tar emot tre argument i form av double. Argumenten är av helt olika värden.

        //[TestMethod]
        //public void isScaleneTest2()
        //{
        //    Triangle tri = new Triangle(1.0, 2.0, 3.0);
        //    Assert.IsTrue(tri.isScalene());
        //}

        ////Test to pass, på metod som kontrollerar om triangeln har tre sidor som är olika från varandra. 
        ////Detta genom konstruktor som tar emot tre argument i form av double. Argumenten är av helt olika värden. Ett av arguemnten är negativt.

        ////[TestMethod]
        ////public void isScaleneTest3()
        ////{
        ////    Triangle tri = new Triangle(-1.0, 2.0, 3.0);
        ////    Assert.IsTrue(tri.isScalene());
        ////}

        ////Test to pass, på metod som kontrollerar om triangeln har tre sidor som är olika från varandra. 
        ////Detta genom konstruktor som tar emot tre argument i form av double. Argumenten är av samma värde. De är högre tal än testerna innan.

        //[TestMethod]
        //public void isScaleneTest4()
        //{
        //    Triangle tri = new Triangle(1000.0, 1000.0, 1000.0);
        //    Assert.IsFalse(tri.isScalene());
        //}

        ////[TestMethod]
        ////[ExpectedException(typeof(ArgumentException))]
        ////public void exceptionTest1()
        ////{
        ////    Triangle tri = new Triangle(-1, -1, -1);
        ////}

        //Test to pass, av metod för likbenta trianglar, samt test av kontruktor med 3 st argument i form av double.
        [TestMethod]
        public void IsIsoscelesTest1()
        {
            Triangle tri = new Triangle(1, 1, 2);
            Assert.IsTrue(tri.isIsosceles());
        }

        //Test to fail, av metod för likbenta trianglar, samt test av kontruktor med 3 st argument i form av double.
        [TestMethod]
        public void IsIsoscelesTest2()
        {
            Triangle tri = new Triangle(1, 2, 3);
            Assert.IsFalse(tri.isIsosceles());
        }

        //Test to pass, av metod för likbenta trianglar, samt test av kontruktor med 3 st argument i form av double med två decimaler.
        [TestMethod]
        public void IsIsoscelesTest3()
        {
            Triangle tri = new Triangle(1.00, 0.50, 1.00);
            Assert.IsTrue(tri.isIsosceles());
        }

        //Test to fail, av metod för likbenta trianglar, samt test av kontruktor med 3 st argument i form av double med två decimaler.
        [TestMethod]
        public void IsIsoscelesTest4()
        {
            Triangle tri = new Triangle(1.00, 0.50, 2.00);
            Assert.IsFalse(tri.isIsosceles());
        }




        //Test to pass, av metod för liksidiga trianglar, samt test av kontruktor med 3 st argument i form av double.
        [TestMethod]
        public void IsEquilateralTest1()
        {
            Triangle tri = new Triangle(10, 10, 10);
            Assert.IsTrue(tri.isEquilateral());
        }

        //Test to fail, av metod för liksidiga trianglar, samt test av kontruktor med 3 st argument i form av double.
        [TestMethod]
        public void IsEquilateralTest2()
        {
            Triangle tri = new Triangle(10, 10, 20);
            Assert.IsFalse(tri.isEquilateral());
        }

        //Test to pass, av metod för liksidiga trianglar, samt test av kontruktor med 3 st argument i form av double med två decimaler.
        [TestMethod]
        public void IsEquilateralTest3()
        {
            Triangle tri = new Triangle(10.26, 10.26, 10.26);
            Assert.IsTrue(tri.isEquilateral());
        }

        //Test to fail, av metod för liksiiga trianglar, samt test av kontruktor med 3 st argument i form av double med två decimaler.
        [TestMethod]
        public void IsEquilateralTest4()
        {
            Triangle tri = new Triangle(10.26, 10.26, 10.27);
            Assert.IsFalse(tri.isEquilateral());
        }





        //Test to pass, av metod för oliksidiga trianglar, samt test av kontruktor med 3 st argument i form av double.
        [TestMethod]
        public void IsScaleneTest1()
        {
            Triangle tri = new Triangle(10, 11, 12);
            Assert.IsTrue(tri.isScalene());
        }

        //Test to fail, av metod för oliksidiga trianglar, samt test av kontruktor med 3 st argument i form av double.
        [TestMethod]
        public void IsScaleneTest2()
        {
            Triangle tri = new Triangle(10, 10, 10);
            Assert.IsFalse(tri.isScalene());
        }

        //Test to pass, av metod för oliksidiga trianglar, samt test av kontruktor med 3 st argument i form av double med två decimaler.
        [TestMethod]
        public void IsScalenetest3()
        {
            Triangle tri = new Triangle(10.26, 10.27, 10.28);
            Assert.IsTrue(tri.isScalene());
        }

        //Test to fail, av metod för oliksidiga trianglar, samt test av kontruktor med 3 st argument i form av double med två decimaler.
        [TestMethod]
        public void IsScaleneTest4()
        {
            Triangle tri = new Triangle(10.26, 10.26, 10.26);
            Assert.IsFalse(tri.isScalene());
        }




        //Test-metoder för att testa att ett exception kastas vid ett konstruktor-anrop med ett negativt tal.
        [TestMethod]
        public void ExceptionTest1()
        {
            try
            {
                Triangle tri = new Triangle(-1, 1, 1);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
        }

        //Test-metoder för att testa att ett exception kastas vid ett konstruktor-anrop med två negativa tal.
        [TestMethod]
        public void ExceptionTest2()
        {
            try
            {
                Triangle tri = new Triangle(-1, -1, 1);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
        }

        //Test-metoder för att testa att ett exception kastas vid ett konstruktor-anrop med tre negativa tal.
        [TestMethod]
        public void ExceptionTest3()
        {
            try
            {
                Triangle tri = new Triangle(-1, -1, -1);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
        }
    }
}
