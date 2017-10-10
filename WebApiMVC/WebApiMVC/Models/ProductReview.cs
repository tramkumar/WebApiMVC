using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApiMVC.ViewModel;

namespace WebApiMVC.Models
{
    public class ProductReview
    {
        public long Rating { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
        public int Reviews_Id { get; set; }
        public int Product_Id { get; set; }

        ////public List<Product> ProductVM { get; set; }

        //public List<ProductReview> ProductReviewVM { get; set; }

        public Nullable<System.DateTime> DatePublished { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Brand { get; set; }

    }
}