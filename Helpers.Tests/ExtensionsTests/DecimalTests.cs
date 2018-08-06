using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers.Extensions;

namespace Helpers.Tests.ExtensionsTests
{
    [TestClass]
    public class DecimalTests
    {
        [TestMethod]
        public void ToNumberFormatTest()
        {
            //Arrange
            decimal? d = 10000.00m;

            //Act
            var result = d.ToNumberFormat();

            //Assert
            Assert.AreEqual("10,000.00", result);
        }

        [TestMethod]
        public void ToPercentageFormat()
        {
            //Arrange
            decimal? d = 0.8526m;

            //Act
            var result = d.ToPercentageFormat();

            //Assert
            Assert.AreEqual("85.26 %", result);
        }
    }
}
