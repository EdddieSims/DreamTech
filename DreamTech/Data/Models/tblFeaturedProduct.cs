using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tblFeaturedProduct
    {
        public int feature_id { get; set; }
        public int product_id { get; set; }
        public bool active { get; set; }
    }
}
