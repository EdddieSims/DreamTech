using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class CategoryRepo
    {
        public List<console.Models.tblProductCategory> GetAllCategories()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tblProductCategories.Where(t => t.category_id > 0).ToList();
            }
        }

        public bool SaveCategory(console.Models.tblProductCategory entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tblProductCategories.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tblProductCategory GetCategory(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from c in context.tblProductCategories where c.category_id == id select c).SingleOrDefault();
            }
        }

        public bool UpdateCategory(console.Models.tblProductCategory entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tblProductCategory cat = (from c in context.tblProductCategories where c.category_id == entity.category_id select c).First();

                cat.product_category = entity.product_category;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteCategory(console.Models.tblProductCategory entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tblProductCategories.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}