using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiMVC.Controllers;
using System.Web.Mvc;
using WebApiMVC.Models;
using System.Collections.Generic;

namespace WebApiMVCTest.Controllers
{
    [TestClass]
    public class ReviewControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            ReviewController controller = new ReviewController();
           
            //Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReviewDetails()
        {
            //Arrange
            ReviewController controller = new ReviewController();

            //Act
            ViewResult result = controller.ReviewDetails(10) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete()
        {
            //Arrange
            ReviewController controller = new ReviewController();

            //Act
            ViewResult result = controller.Delete(7) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
