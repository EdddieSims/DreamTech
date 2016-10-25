using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tblProduct
    {
        public tblProduct()
        {
            this.tbl_WishlistItem = new List<tbl_WishlistItem>();
        }

        public int product_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int units { get; set; }
        public int categoty_id { get; set; }
        public int price_id { get; set; }
        public int type_id { get; set; }
        public virtual btl_ProductPrice btl_ProductPrice { get; set; }
        public virtual tbl_ProductType tbl_ProductType { get; set; }
        public virtual ICollection<tbl_WishlistItem> tbl_WishlistItem { get; set; }
        public virtual tblProductCategory tblProductCategory { get; set; }
    }
}
