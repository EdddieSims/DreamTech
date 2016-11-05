using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class CartItemRepo
    {
        public List<console.Models.tbl_CartItem> GetAllCartItems()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_CartItem.Where(t => t.cart_item_id > 0).ToList();
            }
        }

        public bool SaveCartItem(console.Models.tbl_CartItem entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_CartItem.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_CartItem GetCartItem(string refernce, int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from c in context.tbl_CartItem where (c.cart_ref == refernce) where (c.product_id == id) select c).SingleOrDefault();
            }
        }

        public bool UpdateCartItem(console.Models.tbl_CartItem entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_CartItem cartItem = (from u in context.tbl_CartItem where (u.cart_ref == entity.cart_ref) where (u.product_id == entity.product_id) select u).First();

                cartItem.cart_ref = entity.cart_ref;
                cartItem.product_id = entity.product_id;
                cartItem.quantity = entity.quantity;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteCartItem(console.Models.tbl_CartItem entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_CartItem.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}