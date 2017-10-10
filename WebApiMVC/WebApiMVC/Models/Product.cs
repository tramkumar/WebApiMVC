using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMVC.Models
{
    public class Product
    {

        public Nullable<System.DateTime> DatePublished { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string ShortDescription { get; set; }
        [Display(Name = "Brand")]
        public string Brand { get; set; }
        [Display(Name = "ProductId")]
        public int Product_Id { get; set; }

    }
}