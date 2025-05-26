using Xunit;
using Moq;
using AirBnb.Controllers;
using AirBnb.Models;
using AirBnb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirBnb.UnitTests.Controllers
{
    public class ListingsControllerTests
    {
        [Fact]
        public async Task Index_ReturnsView_WithListings()
        {
            // Arrange
            var mockRepo = new Mock<IBookingRepository>();
            mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Listing>
            {
                new Listing { Id = 1, Title = "Test 1" },
                new Listing { Id = 2, Title = "Test 2" }
            });

            var controller = new ListingsController(mockRepo.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Listing>>(viewResult.ViewData.Model);
            Assert.Equal(2, ((List<Listing>)model).Count);
        }
    }
}
