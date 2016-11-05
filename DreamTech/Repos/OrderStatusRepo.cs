using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class OrderStatusRepo
    {
        public List<console.Models.tbl_OrderStatus> GetAllOrderStatuses()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_OrderStatus.Where(t => t.status_id > 0).ToList();
            }
        }

        public bool SaveStatus(console.Models.tbl_OrderStatus entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_OrderStatus.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_OrderStatus GetStatus(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from s in context.tbl_OrderStatus where s.status_id == id select s).SingleOrDefault();
            }
        }

        public bool UpdateStatus(console.Models.tbl_OrderStatus entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_OrderStatus status = (from s in context.tbl_OrderStatus where s.status_id == entity.status_id select s).First();

                status.status = entity.status;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteDeleteStatus(console.Models.tbl_OrderStatus entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_OrderStatus.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}