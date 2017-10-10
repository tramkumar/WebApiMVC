using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApiMVC.Models;

namespace WebApiMVC.Controllers
{
    public class ReviewController : Controller
    {
        #region Properties
        List<ProductReview> CVM = new List<ProductReview>();
        ProductClient CC = new ProductClient();
        #endregion
        #region Public Operation
        // GET: Review
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ReviewDetails(int id)
        {
            try
            {

                CVM = CC.find(id).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return View(CVM);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            List<ProductReview> CVM = new List<ProductReview>();
            ProductClient CC = new ProductClient();
            CVM = CC.find(id).ToList();
            ProductReview preview = CVM.First(e => e.Reviews_Id == e.Reviews_Id);
            return View(preview);

        }
        [HttpPost]
        public ActionResult Update(ProductReview cvm)
        {
            ProductClient CC = new ProductClient();
            CC.Edit(cvm);
            return View();

        }

        [HttpPost]
        public ActionResult AddReview(ProductReview cvm)
        {
            try
            {
                CC.Create(cvm);
                return View();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public ActionResult Delete(int id)
        {
            try
            {
                CC.Delete(id);
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        #endregion

    }
}