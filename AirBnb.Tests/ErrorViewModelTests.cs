using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirBnb.Models;  

namespace AirBnb.Tests
{
    [TestClass]
    public class ErrorViewModelTests
    {
        [TestMethod]
        public void ShowRequestId_ReturnsFalse_WhenRequestIdIsNull()
        {
            // Arrange
            var model = new ErrorViewModel { RequestId = null };

            // Act
            bool result = model.ShowRequestId;

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShowRequestId_ReturnsFalse_WhenRequestIdIsEmpty()
        {
            var model = new ErrorViewModel { RequestId = "" };
            Assert.IsFalse(model.ShowRequestId);
        }

        [TestMethod]
        public void ShowRequestId_ReturnsTrue_WhenRequestIdIsSet()
        {
            var model = new ErrorViewModel { RequestId = "ABC123" };
            Assert.IsTrue(model.ShowRequestId);
        }
    }
}