using Xunit;
using Moq;
using AirBnb.Controllers;
using AirBnb.Repositories;
using AirBnb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirBnb.UnitTests.Controllers
{
    public class ListingsControllerTests
    {
        [Fact]
        public async Task Index_ReturnsViewResult_WithListOfListings()
        {
            // Arrange
            var mockRepo = new Mock<IListingRepository>();
            mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Listing>
            {
                new Listing { Id = 1, Title = "Test Listing 1" },
                new Listing { Id = 2, Title = "Test Listing 2" }
            });

            var controller = new ListingsController(mockRepo.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Listing>>(viewResult.Model);
            Assert.Equal(2, ((List<Listing>)model).Count);
        }
    }
}
