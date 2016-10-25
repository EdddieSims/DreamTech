using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_ProductType
    {
        public tbl_ProductType()
        {
            this.tblProducts = new List<tblProduct>();
        }

        public int type_id { get; set; }
        public string product_type { get; set; }
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
