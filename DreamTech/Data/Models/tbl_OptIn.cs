using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_OptIn
    {
        public int opt_id { get; set; }
        public int user_id { get; set; }
        public int opt_type_id { get; set; }
    }
}
