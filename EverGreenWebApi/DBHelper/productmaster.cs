//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EverGreenWebApi.DBHelper
{
    using System;
    using System.Collections.Generic;
    
    public partial class productmaster
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> GST { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string TaxType { get; set; }
        public string UOM { get; set; }
        public string SweetsReset { get; set; }
        public string ProductDetails { get; set; }
        public string Lock { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
