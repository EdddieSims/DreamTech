using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class btl_ProductPrice
    {
        public btl_ProductPrice()
        {
            this.tblProducts = new List<tblProduct>();
            this.tbl_WishlistItem = new List<tbl_WishlistItem>();
        }

        public int price_id { get; set; }
        public Nullable<decimal> product_price { get; set; }
        public virtual ICollection<tblProduct> tblProducts { get; set; }
        public virtual ICollection<tbl_WishlistItem> tbl_WishlistItem { get; set; }
    }
}
