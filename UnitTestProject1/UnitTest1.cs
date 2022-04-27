using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Sum_a_b()
        {
            //arrange
            double a = 5.5, b = 6.3;
            double expected = a + b;
            //act
            double actual = Class1.Plus(a, b);
            //assert
            Assert.AreEqual(expected, actual, 0.1, "Погрешность вышла за границу 0,1");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod_DivisionZero()
        {
            double a = 5.5, b = 0;
            double expected = a / b;
            double actual = Class1.Delit(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Minus()
        {
            double a = 5.5, b = 6.3;
            double expected = a - b;
            double actual = Class1.Minus(a, b);
            Assert.AreEqual(expected, actual, 0.1, "Погрешность привышает 0,1");
        }

        [TestMethod]
        public void TestMethod_Minus2()
        {
            double a = 5.5, b = 6.3;
            double expected = a - b;
            double actual = Class1.Minus(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Umnoj()
        {
            double a = 5.5, b = 6.3;
            double expected = a * b;
            double actual = Class1.Umnoj(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Division()
        {
            double a = 5.5, b = 2;
            double expected = a / b;
            double actual = Class1.Delit(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
