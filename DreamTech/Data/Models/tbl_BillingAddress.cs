using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_BillingAddress
    {
        public tbl_BillingAddress()
        {
            this.tbl_User = new List<tbl_User>();
        }

        public int billing_id { get; set; }
        public string address_line { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public int postal_code { get; set; }
        public int country_id { get; set; }
        public virtual tblCountry tblCountry { get; set; }
        public virtual ICollection<tbl_User> tbl_User { get; set; }
    }
}
