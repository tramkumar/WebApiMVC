using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiMVC.Models;

namespace WebApiMVC.ViewModel
{
    public class ProductViewModel
    {
        public Product customer { get; set; }

        public IEnumerable<ProductReview> Preview { get; set; }

    }
}