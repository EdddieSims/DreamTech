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
            //var repo = new Repos.ProductRepo();
            //var prodList = repo.GetAllProducts();

            var idList = Session["CartItems"];
            return View();
        }
    }
}