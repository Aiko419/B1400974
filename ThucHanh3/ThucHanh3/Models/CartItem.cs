using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucHanh3.Models
{
    public class CartItem
    {
        public Book ProductOrder { get; set; }
        public int Quality { get; set; }
    }
}