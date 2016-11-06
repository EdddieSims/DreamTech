using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class DeliveryAddressRepo
    {
        public List<console.Models.tbl_DelivetyAddresses> GetAllDAddress()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_DelivetyAddresses.Where(t => t.delivery_id > 0).ToList();
            }
        }

        public bool SaveDAddress(console.Models.tbl_DelivetyAddresses entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_DelivetyAddresses.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_DelivetyAddresses GetDAddress(tbl_DelivetyAddresses address)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from d in context.tbl_DelivetyAddresses where d.delivery_id == address.delivery_id select d).SingleOrDefault();
            }
        }

        public bool UpdateDAddress(console.Models.tbl_DelivetyAddresses entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_DelivetyAddresses address = (from d in context.tbl_DelivetyAddresses where d.delivery_id == entity.delivery_id select d).First();

                address.address_line = entity.address_line;
                address.suburb = entity.suburb;
                address.city = entity.city;
                address.postal_code = entity.postal_code;
                address.country_id = entity.country_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteDAddress(console.Models.tbl_DelivetyAddresses entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_DelivetyAddresses.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}