using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiMVC.Models;


namespace WebApiMVC.ViewModel
{
    public class ProductReviewModel
    {
        public Nullable<System.DateTime> DatePublished { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Brand { get; set; }
        public int Product_Id { get; set; }
        public long Rating { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
        public int Reviews_Id { get; set; }
    }
}