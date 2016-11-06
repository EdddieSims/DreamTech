using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class OrderRepo
    {
        public List<console.Models.tbl_Order> GetAllOrders()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_Order.Where(t => t.order_id > 0).ToList();
            }
        }

        public bool SaveOrder(console.Models.tbl_Order entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_Order.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_Order GetOrder(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from o in context.tbl_Order where o.order_id == id select o).SingleOrDefault();
            }
        }

        public bool UpdateOrder(console.Models.tbl_Order entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_Order order = (from o in context.tbl_Order where o.order_id == entity.order_id select o).First();

                order.user_id = entity.user_id;
                order.cart_ref = entity.cart_ref;
                order.order_status_id = entity.order_status_id;
                order.delivery_address_id = entity.delivery_address_id;
                order.order_total = entity.order_total;
                order.promo_id = entity.promo_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteOrder(console.Models.tbl_Order entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_Order.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}