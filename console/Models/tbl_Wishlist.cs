using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial class tbl_Wishlist
    {
        public int wishlist_id { get; set; }
        public int user_id { get; set; }
        public virtual tbl_User tbl_User { get; set; }
    }
}
