using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp1;

namespace testing
{
    public class Tests
    {
        [TestMethod]
        public void TestMethod_Sum_a_b()
        {
            //arrange
            double a = 5.5, b = 6.3;
            double expected = a + b;
            //act
            double actual = Convert.ToDouble(Class1.Plus(a, b));
            //assert
            Assert.AreEqual(expected, actual, 0.1, "Погрешность вышла за границу 0,1");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod_Division()
        {
            double a = 5.5, b = 0;
            double expected = a / b;
            double actual = Convert.ToDouble(Class1.Delit(a, b));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Minus()
        {
            double a = 5.5, b = 6.3;
            double expected = a - b;
            double actual = Convert.ToDouble(Class1.Minus(5.5, 6.2));
            Assert.AreEqual(expected, actual, 0.1, "Погрешность привышает 0,1");
        }

        [TestMethod]
        public void TestMethod_Minus2()
        {
            double a = 5.5, b = 6.3;
            double expected = a - b;
            double actual = Convert.ToDouble(Class1.Minus(5.5, 6.2));
            Assert.AreEqual(expected, actual);
        }
    }
}