using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class CustomerContactRepo
    {
        public List<console.Models.tbl_CustomerContact> GetAllContacts()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_CustomerContact.Where(t => t.contact_id > 0).ToList();
            }
        }

        public bool SaveContact(console.Models.tbl_CustomerContact entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_CustomerContact.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_CustomerContact GetContact(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from c in context.tbl_CustomerContact where c.contact_id == id select c).SingleOrDefault();
            }
        }

        public bool UpdateContact(console.Models.tbl_CustomerContact entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_CustomerContact contact = (from c in context.tbl_CustomerContact where c.contact_id == entity.contact_id select c).First();

                contact.cell_number = entity.cell_number;
                contact.landline = entity.landline;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteContact(console.Models.tbl_CustomerContact entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_CustomerContact.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}