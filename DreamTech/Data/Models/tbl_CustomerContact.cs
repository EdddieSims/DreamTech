using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_CustomerContact
    {
        public tbl_CustomerContact()
        {
            this.tbl_User = new List<tbl_User>();
        }

        public int contact_id { get; set; }
        public long cell_number { get; set; }
        public Nullable<long> landline { get; set; }
        public virtual ICollection<tbl_User> tbl_User { get; set; }
    }
}
