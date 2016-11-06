using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class DeliveryOptionsRepo
    {
        public List<console.Models.tbl_DeliveryOptions> GetAllDeliveryOptions()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_DeliveryOptions.Where(t => t.delivery_id > 0).ToList();
            }
        }

        public bool SaveDeliveryOption(console.Models.tbl_DeliveryOptions entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_DeliveryOptions.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_DeliveryOptions GetDOption(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from d in context.tbl_DeliveryOptions where d.delivery_id == id select d).SingleOrDefault();
            }
        }

        public bool UpdateDOption(console.Models.tbl_DeliveryOptions entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_DeliveryOptions options = (from d in context.tbl_DeliveryOptions where d.delivery_id == entity.delivery_id select d).First();

                options.delivery_option = entity.delivery_option;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteDeliveryOption(console.Models.tbl_DeliveryOptions entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_DeliveryOptions.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}