//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int Reviews_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public long Rating { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
