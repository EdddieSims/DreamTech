using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_User
    {
        public tbl_User()
        {
            this.tbl_Order = new List<tbl_Order>();
            this.tbl_Wishlist = new List<tbl_Wishlist>();
        }

        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string email_address { get; set; }
        public string password { get; set; }
        public int delivery_id { get; set; }
        public int billing_id { get; set; }
        public int contact_id { get; set; }
        public virtual tbl_BillingAddress tbl_BillingAddress { get; set; }
        public virtual tbl_CustomerContact tbl_CustomerContact { get; set; }
        public virtual tbl_DelivetyAddresses tbl_DelivetyAddresses { get; set; }
        public virtual ICollection<tbl_Order> tbl_Order { get; set; }
        public virtual ICollection<tbl_Wishlist> tbl_Wishlist { get; set; }
    }
}
