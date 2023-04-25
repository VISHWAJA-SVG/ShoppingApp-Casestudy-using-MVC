using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ShoppingApp.Models
{
    public class categoryDetails
    {
        public int categoryId { get; set; }
        [Required (ErrorMessage ="Category  name Required")]
        [StringLength(100,ErrorMessage= "Minimum 3 and minimum 5 and maximum 100 characters are allowed",MinimumLength =3)]
        
        public string categoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}

public class ProductDetails
{
    public int productId { get; set; }
    [Required(ErrorMessage = "Product  name Required")]
    [StringLength(100, ErrorMessage = "Minimum 3 and minimum 5 and maximum 100 characters are allowed", MinimumLength = 3)]

    public string productName { get; set; }
    public Nullable<int> categoryId { get; set; }
    public Nullable<bool> IsActive { get; set; }
    public Nullable<bool> IsDelete { get; set; }
    public string Description { get; set; }
    public string productImg { get; set; }
    [Required]
    [Range(typeof(int),"1","50",ErrorMessage ="Invalid Quantity")]
    public Nullable<int> quantity { get; set; }
    [Required]
    [Range(typeof(decimal), "1", "200000", ErrorMessage = "Invalid Price")]
    public Nullable<decimal> price { get; set; }
    public SelectList Categories { get; set; }
}