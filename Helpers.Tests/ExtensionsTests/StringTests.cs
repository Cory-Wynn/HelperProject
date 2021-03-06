﻿using System;
using Helpers.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests.ExtensionsTests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void RemoveWhiteSpace()
        {
            //Arrange
            var s = "Hello World!";

            //Act
            var result = s.RemoveWhiteSpace();

            //Assert
            Assert.AreEqual("HelloWorld!", result);
        }
    }
}
