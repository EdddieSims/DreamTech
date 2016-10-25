using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tblCountry
    {
        public tblCountry()
        {
            this.tbl_BillingAddress = new List<tbl_BillingAddress>();
            this.tbl_DelivetyAddresses = new List<tbl_DelivetyAddresses>();
        }

        public int country_id { get; set; }
        public string country_name { get; set; }
        public virtual ICollection<tbl_BillingAddress> tbl_BillingAddress { get; set; }
        public virtual ICollection<tbl_DelivetyAddresses> tbl_DelivetyAddresses { get; set; }
    }
}
