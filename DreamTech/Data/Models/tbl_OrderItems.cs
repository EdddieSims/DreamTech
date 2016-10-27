using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_OrderItems
    {
        public int order_item_id { get; set; }
        public string item_reference { get; set; }
        public int product_id { get; set; }
        public int price_id { get; set; }
        public int quantity { get; set; }
    }
}
