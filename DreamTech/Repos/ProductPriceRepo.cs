using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class ProductPriceRepo
    {
        public List<console.Models.btl_ProductPrice> GetAllPrices()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.btl_ProductPrice.Where(t => t.price_id > 0).ToList();
            }
        }

        public bool SavePrice(console.Models.btl_ProductPrice entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.btl_ProductPrice.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public btl_ProductPrice GetPrice(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from p in context.btl_ProductPrice where p.price_id == id select p).SingleOrDefault();
            }
        }

        //public btl_ProductPrice GetMultiplePrices(List<int> priceId)
        //{
        //    using (var context = new console.Models.dream_techContext())
        //    {
        //        List<decimal> priceList;
        //        foreach(int id in priceId)
        //        {
        //            priceList = (from p in context.btl_ProductPrice where p.price_id == id select p).SingleOrDefault();
        //        }
        //        return (from p in context.btl_ProductPrice where p.price_id == id select p).SingleOrDefault();
        //    }
        //}

        public bool UpdatePrice(console.Models.btl_ProductPrice entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                btl_ProductPrice price = (from p in context.btl_ProductPrice where p.price_id == entity.price_id select p).First();

                price.product_price = entity.product_price;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeletePrice(console.Models.btl_ProductPrice entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.btl_ProductPrice.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}