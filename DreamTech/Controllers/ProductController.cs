using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Product
        public ActionResult Index(int? id)
        {
            var repo = new Repos.ProductRepo();

            if (id == null)
            {
                var prodList = repo.GetAllProducts();
                return View(prodList);
            }
            else
            {
                var prodList = repo.GetProductsByCategory(id);
                return View(prodList);
            }
        }



        public ActionResult NewProducts()
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetAllProducts();
            return View(prodList);
        }

        public ActionResult FeaturedProduct()
        {
            var repo = new Repos.FeaturedProductRepo();
            var fProdList = repo.GetAllActiveFeaturedProducts();

            var prodList = getFeaturedProd(fProdList);

            return View(prodList);
        }
    }
}