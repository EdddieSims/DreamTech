using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_Order
    {
        public int order_id { get; set; }
        public int user_id { get; set; }
        public string cart_ref { get; set; }
        public int order_status_id { get; set; }
        public int delivery_address_id { get; set; }
        public decimal? order_total { get; set; }
        public int promo_id { get; set; }
        public virtual tbl_DelivetyAddresses tbl_DelivetyAddresses { get; set; }
        public virtual tbl_OrderStatus tbl_OrderStatus { get; set; }
        public virtual tbl_PromoCode tbl_PromoCode { get; set; }
        public virtual tbl_User tbl_User { get; set; }
    }
}
