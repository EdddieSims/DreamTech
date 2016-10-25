using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_DelivetyAddresses
    {
        public tbl_DelivetyAddresses()
        {
            this.tbl_Order = new List<tbl_Order>();
            this.tbl_User = new List<tbl_User>();
        }

        public int delivery_id { get; set; }
        public string address_line { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public int postal_code { get; set; }
        public int country_id { get; set; }
        public virtual tblCountry tblCountry { get; set; }
        public virtual ICollection<tbl_Order> tbl_Order { get; set; }
        public virtual ICollection<tbl_User> tbl_User { get; set; }
    }
}
