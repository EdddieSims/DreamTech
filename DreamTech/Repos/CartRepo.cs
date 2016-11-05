using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class CartRepo
    {
        public List<console.Models.tbl_Cart> GetAllCarts()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_Cart.Where(t => t.cart_id > 0).ToList();
            }
        }

        public bool SaveCart(console.Models.tbl_Cart entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_Cart.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_Cart GetCart(string reference)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from c in context.tbl_Cart where c.cart_ref == reference select c).SingleOrDefault();
            }
        }

        public bool UpdateCart(console.Models.tbl_Cart entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_Cart cart = (from c in context.tbl_Cart where c.cart_ref == entity.cart_ref select c).First();

                cart.cart_ref = entity.cart_ref;
                cart.cart_total = entity.cart_total;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteCart(console.Models.tbl_Cart entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_Cart.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}