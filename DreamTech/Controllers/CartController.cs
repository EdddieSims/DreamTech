using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class CartController : BaseController
    {
        // GET: Cart
        public ActionResult Index()
        {
            List<int?> list = (Session["CartItems"] as List<int?>) ?? new List<int?>();

            var repo = new Repos.ProductRepo();
            var prodList = repo.GetMutipleProducts(list);

            return View(prodList);
        }
    }
}