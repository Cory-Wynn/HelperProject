using System;
using System.IO;
using System.Reflection;
using Helpers.Logging;
using Helpers.Logging.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests.LoggingTests
{
    [TestClass]
    public class LoggerTests
    {
        private const string LogPath = "Helpers.log";

        [TestMethod]
        public void LogError()
        {
            //Arrange
            ClearLogFile();
            ILogger log = new Logger(); 
            
            //Act
            log.Error("Error Message");

            //Assert
            Assert.IsTrue(File.ReadAllText(LogPath).Contains("Error Message"));
        }

        [TestMethod]
        public void LogWarning()
        {
            //Arrange
            ClearLogFile();
            ILogger log = new Logger();

            //Act
            log.Warning("Warning Message");

            //Assert
            Assert.IsTrue(File.ReadAllText(LogPath).Contains("Warning Message"));
        }

        [TestMethod]
        public void LogInfo()
        {
            //Arrange
            ClearLogFile();
            ILogger log = new Logger();

            //Act
            log.Info("Info Message");

            //Assert
            Assert.IsTrue(File.ReadAllText(LogPath).Contains("Info Message"));
        }

        [TestMethod]
        public void CreateLogFile()
        {
            //Arrange
            DeleteLogFile();
            ILogger log = new Logger();

            //Act
            log.Info("Create Log");

            //Assert
            Assert.IsTrue(File.Exists("Helpers.log"));
        }

        #region Helpers

        private void ClearLogFile()
        {
            File.WriteAllText(LogPath, String.Empty);
        }

        private void DeleteLogFile()
        {
            if (File.Exists("Helpers.log"))
            {
                File.Delete("Helpers.log");
            }
        }
        #endregion
    }
}
