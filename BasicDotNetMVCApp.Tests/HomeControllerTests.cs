using BasicDotNetMVCApp.Controllers;
using BasicDotNetMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDotNetMVCApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController(null); // Pass null for the logger since it's not used in this test

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_PassesCorrectModelToView()
        {
            // Arrange
            var controller = new HomeController(null); // Pass null for the logger since it's not used in this test

            // Act
            var result = controller.Index() as ViewResult;
            var model = result.Model as StudentModel;

            // Assert
            Assert.NotNull(model);
            Assert.Equal("Arpit", model.FirstName);
            Assert.Equal("Dhuriya", model.LastName);
            Assert.Equal(23, model.Age);
            Assert.Equal("arpit.dhuriya@nagarro.com", model.Email);
        }

        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController(null);

            // Act
            var result = controller.Privacy();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Privacy_ViewNameIsPrivacy()
        {
            // Arrange
            var controller = new HomeController(null);

            // Act
            var result = controller.Privacy() as ViewResult;

            // Assert
            Assert.Equal("Privacy", result?.ViewName);
        }

        [Fact]
        public void Error_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController(null);

            // Act
            var result = controller.Error();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
