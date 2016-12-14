using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_Cart
    {
        public int cart_id { get; set; }
        public string cart_ref { get; set; }
        public decimal? cart_total { get; set; }
    }
}
