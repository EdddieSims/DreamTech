using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class UserRepo
    {
        public List<console.Models.tbl_User> GetAllUsers()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_User.Where(t => t.user_id > 0).ToList();
            }
        }

        public bool SaveUser(console.Models.tbl_User entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_User.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_User GetUser(string email)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from t in context.tbl_User where t.email_address == email select t).SingleOrDefault();
            }
        }

        public tbl_User GetLoginDetails(string email, string password)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from t in context.tbl_User where t.email_address == email && t.password == password select t).SingleOrDefault();
            }
        }

        public bool UpdateUser(console.Models.tbl_User entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_User user = (from u in context.tbl_User where u.email_address == entity.email_address select u).First();

                user.user_name = entity.user_name;
                user.user_surname = entity.user_surname;
                user.email_address = entity.email_address;
                user.password = entity.password;
                user.delivery_id = entity.delivery_id;
                user.billing_id = entity.billing_id;
                user.contact_id = entity.contact_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteUser(console.Models.tbl_User entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_User.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}