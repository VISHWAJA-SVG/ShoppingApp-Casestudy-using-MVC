//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class shippingDetail
    {
        public int shippingId { get; set; }
        public Nullable<int> customerId { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public Nullable<int> orderId { get; set; }
        public Nullable<decimal> amountPaid { get; set; }
        public string paymentType { get; set; }
    
        public virtual customer customer { get; set; }
    }
}
