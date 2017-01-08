using BinomialCalculator.Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CalculationTest
    {
        const int Delta = 0;

        #region Combinations(uint, uint)
        [TestMethod]
        public void Combinations_General()
        {
            Assert.AreEqual(120, Calculation.Combinatations(10, 3), Delta, "General case failed.");
        }

        [TestMethod]
        public void Combinations_General2()
        {
            Assert.AreEqual(120, Calculation.Combinatations(10, 7), Delta, "General case 2 failed.");
        }

        [TestMethod]
        public void Combinations_Boundary_Lower()
        {
            Assert.AreEqual(1, Calculation.Combinatations(10, 0), Delta, "Boundary lower case failed.");
        }

        [TestMethod]
        public void Combinations_Boundary_Upper()
        {
            Assert.AreEqual(1, Calculation.Combinatations(10, 10), Delta, "Boundary upper case failed.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_Error_Upper()
        {
            Calculation.Combinatations(10, 11);
        }
        #endregion
        #region Factorial(uint)
        [TestMethod]
        public void Factorial_General()
        {
            Assert.AreEqual(24, Calculation.Factorial(4), Delta, "General case failed.");
        }

        [TestMethod]
        public void Factorial_Boundary()
        {
            Assert.AreEqual(1, Calculation.Factorial(1), Delta, "Boundary case failed.");
        }

        [TestMethod]
        public void Factorial_Boundary2()
        {
            Assert.AreEqual(1, Calculation.Factorial(0), Delta, "Boundary case 2 failed.");
        }
        #endregion
    }
}
