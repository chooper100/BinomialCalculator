using BinomialCalculator.Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BinomialTest
    {
        const double Delta = 0.0001;

        #region Mean
        [TestMethod]
        public void Mean_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(1, X.Mean, Delta, "General case failed.");
        }
        #endregion
        #region Variance
        [TestMethod]
        public void Variance_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.8, X.Variance, Delta, "General case failed.");
        }
        #endregion
        #region StandardDeviation
        [TestMethod]
        public void StandardDeviation_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.89443, X.StandardDeviation, Delta, "General case failed.");
        }
        #endregion
        #region Constructor
        [TestMethod]
        public void Constructor_Boundary_Lower()
        {
            Binomial X = new Binomial(5, 0);

            Assert.AreEqual(0, X.p, 0, "Boundary lower case failed.");
        }

        [TestMethod]
        public void Constructor_Boundary_Upper()
        {
            Binomial X = new Binomial(5, 1);

            Assert.AreEqual(1, X.p, 0, "Boundary upper case failed.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_Error_Lower()
        {
            Binomial X = new Binomial(5, -0.2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_Error_Upper()
        {
            Binomial X = new Binomial(5, 1.2);
        }
        #endregion
        #region GetProbability(uint)
        [TestMethod]
        public void GetProbability_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.0512, X.GetProbability(3), Delta, "General case failed.");
        }

        [TestMethod]
        public void GetProbability_Boundary_Lower()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.32768, X.GetProbability(0), Delta, "Lower case failed.");
        }

        [TestMethod]
        public void GetProbability_Boundary_Upper()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.00032, X.GetProbability(5), Delta, "Upper case failed.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetProbability_Error_Upper()
        {
            Binomial X = new Binomial(5, 0.2);

            X.GetProbability(6);
        }
        #endregion
        #region GetProbability(uint, uint)
        [TestMethod]
        public void GetProbability2_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.2624, X.GetProbability(2, 4), Delta, "General case failed.");
        }

        [TestMethod]
        public void GetProbability2_General2()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.0512, X.GetProbability(3, 3), Delta, "General case 2 failed.");
        }

        [TestMethod]
        public void GetProbability2_Boundary()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(1, X.GetProbability(0, 5), Delta, "Boundary case failed.");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetProbability2_Error()
        {
            Binomial X = new Binomial(5, 0.2);

            X.GetProbability(3, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetProbability2_Error2()
        {
            Binomial X = new Binomial(5, 0.2);

            X.GetProbability(6, 8);
        }
        #endregion
        #region GetCumulativeProbability(uint)
        [TestMethod]
        public void GetCumulativeProbability_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(0.99328, X.GetCumulativeProbability(3), Delta, "General case failed.");
        }
        
        [TestMethod]
        public void GetCumulativeProbability_Boundary()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(1, X.GetCumulativeProbability(5), Delta, "General case failed.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetCumulativeProbability_Error()
        {
            Binomial X = new Binomial(5, 0.2);

            X.GetCumulativeProbability(6);
        }
        #endregion
        #region Inverse()
        [TestMethod]
        public void Inverse_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual(new Binomial(5, 0.8), X.Inverse(), "General case failed.");
        }
        #endregion
        #region ToString()
        [TestMethod]
        public void ToString_General()
        {
            Binomial X = new Binomial(5, 0.2);

            Assert.AreEqual("X~B(5, 0.2)", X.ToString(), "General case failed.");
        }
        #endregion
    }
}
