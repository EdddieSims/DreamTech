using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_OrderStatus
    {
        public tbl_OrderStatus()
        {
            this.tbl_Order = new List<tbl_Order>();
        }

        public int status_id { get; set; }
        public string status { get; set; }
        public virtual ICollection<tbl_Order> tbl_Order { get; set; }
    }
}
