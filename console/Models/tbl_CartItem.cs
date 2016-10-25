using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_CartItem
    {
        public int cart_item_id { get; set; }
        public string cart_ref { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
    }
}
