using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiMVC.Controllers;
using System.Web.Mvc;
using WebApiMVC.Models;
using System.Collections.Generic;

namespace WebApiMVCTest.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            ProductController controller = new ProductController();
            ProductClient CC = new ProductClient();
            IEnumerable<Product> listProducts = CC.findAll();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
