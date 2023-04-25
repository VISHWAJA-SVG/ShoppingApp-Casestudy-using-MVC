using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingApp.DAL;

namespace ShoppingApp.Models.Home
{
    public class Item
    {
        public product Product { get; set; }
        public int Quantity { get; set; }
    }
}