using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_WishlistItem
    {
        public int wishlist_item_id { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public int price_id { get; set; }
        public virtual btl_ProductPrice btl_ProductPrice { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}
