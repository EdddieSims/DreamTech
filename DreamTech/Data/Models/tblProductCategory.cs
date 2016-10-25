using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tblProductCategory
    {
        public tblProductCategory()
        {
            this.tblProducts = new List<tblProduct>();
        }

        public int category_id { get; set; }
        public string product_category { get; set; }
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
