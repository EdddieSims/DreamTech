using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_PromoCode
    {
        public tbl_PromoCode()
        {
            this.tbl_Order = new List<tbl_Order>();
        }

        public int promo_id { get; set; }
        public int promo_type_id { get; set; }
        public int num_of_uses { get; set; }
        public virtual ICollection<tbl_Order> tbl_Order { get; set; }
    }
}
