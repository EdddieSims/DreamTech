using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using console.Models;

namespace DreamTech.Repos
{
    public class ProductRepo
    {
        public List<console.Models.tblProduct> GetAllProducts()
        {
            using (var context = new console.Models.dream_techContext())
            {
                return context.tblProducts.Include("tblProductCategory").Include("btl_ProductPrice").Where(t => t.product_id > 0).ToList();
            }
        }

        public List<console.Models.tblProduct> GetProductByName(string name)
        {
            using (var context = new console.Models.dream_techContext())
            {
                var products = context.tblProducts.Include("tblProductCategory").Include("btl_ProductPrice").Where(t => t.name.Contains(name)).ToList();
                return products;
            }
        }

        public bool SaveProduct(console.Models.tblProduct entity)
        {
            bool result = false;

            using (var context = new console.Models.dream_techContext())
            {
                context.tblProducts.Add(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public tblProduct GetProduct(int id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                return (from p in context.tblProducts where p.product_id == id select p).SingleOrDefault();
            }
        }

        public List<tblProduct> GetMutipleProducts(List<int?> idList)
        {
            
            using (var context = new console.Models.dream_techContext())
            {
                var products = context.tblProducts.Include("tblProductCategory").Include("btl_ProductPrice").Where(p => idList.Contains(p.product_id)).ToList();
                return products;
            }

            
        }

        public List<console.Models.tblProduct> GetProductsByCategory(int? id)
        {
            using (var context = new console.Models.dream_techContext())
            {
                var product = context.tblProducts.Include("tblProductCategory").Include("btl_ProductPrice").Where(p => p.categoty_id == id).ToList();
                return product;
            }
        }

        public bool UpdateProduct(console.Models.tblProduct entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                tblProduct product = (from p in context.tblProducts where p.product_id == entity.product_id select p).First();

                product.name = entity.name;
                product.description = entity.description;
                product.units = entity.units;
                product.categoty_id = entity.categoty_id;
                product.price_id = entity.price_id;
                product.type_id = entity.type_id;

                result = context.SaveChanges() > 1;
            }
            return result;
        }

        public bool DeleteProduct(console.Models.tblProduct entity)
        {
            bool result = false;
            using (var context = new console.Models.dream_techContext())
            {
                context.tblProducts.Remove(entity);
                result = context.SaveChanges() > 1;
            }
            return result;
        }
    }
}