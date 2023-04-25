using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models
{
    public class Shippingdetail
    {
        [Required]
        public int shippingId { get; set; }
        [Required]
        public Nullable<int> customerId { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string zipcode { get; set; }
        [Required]
        public Nullable<int> orderId { get; set; }
        [Required]
        public Nullable<decimal> amountPaid { get; set; }
        [Required]
        public string paymentType { get; set; }
    }
}