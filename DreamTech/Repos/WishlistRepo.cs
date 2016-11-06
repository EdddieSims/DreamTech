using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class WishlistRepo
    {
        public List<console.Models.tbl_WishlistItem> GetAllWishlistItems()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_WishlistItem.Where(t => t.wishlist_item_id > 0).ToList();
            }
        }

        public bool SaveWishlistItem(console.Models.tbl_WishlistItem entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_WishlistItem.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_Wishlist GetWishlist(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from w in context.tbl_Wishlist where w.user_id == id select w).SingleOrDefault();
            }
        }

        public bool UpdateWishlist(console.Models.tbl_Wishlist entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_Wishlist wishlist = (from w in context.tbl_Wishlist where w.wishlist_id == entity.wishlist_id select w).First();

                wishlist.user_id = entity.user_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteWishlistItem(console.Models.tbl_WishlistItem entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_WishlistItem.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}