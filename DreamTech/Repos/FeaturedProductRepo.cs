using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class FeaturedProductRepo
    {
        public List<console.Models.tblFeaturedProduct> GetAllFeaturedProducts()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tblFeaturedProducts.Where(t => t.feature_id > 0).ToList();
            }
        }

        public List<console.Models.tblFeaturedProduct> GetAllActiveFeaturedProducts()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tblFeaturedProducts.Where(t => t.active == true).ToList();
            }
        }

        public bool SaveFeaturedProduct(console.Models.tblFeaturedProduct entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tblFeaturedProducts.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tblFeaturedProduct GetFeaturedProd(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from f in context.tblFeaturedProducts where f.feature_id == id select f).SingleOrDefault();
            }
        }

        public bool UpdateFeaturedProd(console.Models.tblFeaturedProduct entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tblFeaturedProduct feature = (from f in context.tblFeaturedProducts where f.feature_id == entity.feature_id select f).First();

                feature.active = entity.active;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteFProduct(console.Models.tblFeaturedProduct entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tblFeaturedProducts.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}