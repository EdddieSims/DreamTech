using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class BillingAddressRepo
    {
        public List<console.Models.tbl_BillingAddress> GetAllBAddresses()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_BillingAddress.Where(t => t.billing_id > 0).ToList();
            }
        }

        public bool SaveBAddress(console.Models.tbl_BillingAddress entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_BillingAddress.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_BillingAddress GetBAddress(tbl_BillingAddress address)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from t in context.tbl_BillingAddress where t.billing_id == address.billing_id select t).SingleOrDefault();
            }
        }

        public bool UpdateBAddress(console.Models.tbl_BillingAddress entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_BillingAddress address = (from b in context.tbl_BillingAddress where b.billing_id == entity.billing_id select b).First();

                address.address_line = entity.address_line;
                address.suburb = entity.suburb;
                address.city = entity.city;
                address.postal_code = entity.postal_code;
                address.country_id = entity.country_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteBAddress(console.Models.tbl_BillingAddress entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_BillingAddress.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}