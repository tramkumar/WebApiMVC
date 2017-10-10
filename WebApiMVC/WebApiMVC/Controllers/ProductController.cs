using System;
using System.Web.Mvc;
using WebApiMVC.Models;

namespace WebApiMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product  
        public ActionResult Index()
        {
            try
            {
                ProductClient CC = new ProductClient();
                ViewBag.listProducts = CC.findAll();
                return View();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}