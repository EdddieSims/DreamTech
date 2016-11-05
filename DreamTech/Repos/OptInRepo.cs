using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class OptInRepo
    {
        public List<console.Models.tbl_OptIn> GetAllOpts()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tbl_OptIn.Where(t => t.opt_id > 0).ToList();
            }
        }

        public bool SaveOpt(console.Models.tbl_OptIn entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_OptIn.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tbl_OptIn GetOpt(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from o in context.tbl_OptIn where o.opt_id == id select o).SingleOrDefault();
            }
        }

        public bool UpdateOpt(console.Models.tbl_OptIn entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tbl_OptIn opt = (from o in context.tbl_OptIn where o.opt_id == entity.opt_id select o).First();

                opt.user_id = entity.user_id;
                opt.opt_type_id = entity.opt_type_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteOpt(console.Models.tbl_OptIn entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tbl_OptIn.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}