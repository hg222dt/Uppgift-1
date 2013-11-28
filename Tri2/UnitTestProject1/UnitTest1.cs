using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangelUnitTest
    {
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
