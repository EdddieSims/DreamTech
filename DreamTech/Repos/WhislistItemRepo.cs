using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class WhislistItemRepo
    {
        public List<console.Models.tbl_Wishlist> GetAllWishlists()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_Wishlist.Where(t => t.wishlist_id > 0).ToList();
            }
        }

        public bool SaveWishlist(console.Models.tbl_Wishlist entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_Wishlist.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_WishlistItem GetWishlistItem(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from w in context.tbl_WishlistItem where w.wishlist_item_id == id select w).SingleOrDefault();
            }
        }

        public bool UpdateWishlistItem(console.Models.tbl_WishlistItem entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_WishlistItem wishlistItem = (from w in context.tbl_WishlistItem where w.wishlist_item_id == entity.wishlist_item_id select w).First();

                wishlistItem.price_id = entity.price_id;
                wishlistItem.product_id = entity.product_id;
                wishlistItem.price_id = entity.price_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteWishlist(console.Models.tbl_Wishlist entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_Wishlist.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}