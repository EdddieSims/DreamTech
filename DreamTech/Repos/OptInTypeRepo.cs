using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class OptInTypeRepo
    {
        public List<console.Models.tbl_OptInType> GetAllOptTypes()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_OptInType.Where(t => t.opt_type_id > 0).ToList();
            }
        }

        public bool SaveOptType(console.Models.tbl_OptInType entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_OptInType.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_OptInType GetOptType(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from o in context.tbl_OptInType where o.opt_type_id == id select o).SingleOrDefault();
            }
        }

        public bool UpdateOptType(console.Models.tbl_OptInType entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_OptInType type = (from o in context.tbl_OptInType where o.opt_type_id == entity.opt_type_id select o).First();

                type.optin_category = entity.optin_category;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteOptType(console.Models.tbl_OptInType entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_OptInType.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}