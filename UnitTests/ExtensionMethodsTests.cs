using BinomialCalculator.Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ExtensionMethodsTest
    {
        #region DecimalFormat(double)
        [TestMethod]
        public void DecimalFormat_General()
        {
            Assert.AreEqual("0.5000", (0.5d).DecimalFormat(), "General case failed.");
        }

        [TestMethod]
        public void DecimalFormat_General2()
        {
            Assert.AreEqual("1.0000", (1d).DecimalFormat(), "General case 2 failed.");
        }

        [TestMethod]
        public void DecimalFormat_General3()
        {
            Assert.AreEqual("0.3333", (0.333333d).DecimalFormat(), "General case 3 failed.");
        }
        #endregion
    }
}
