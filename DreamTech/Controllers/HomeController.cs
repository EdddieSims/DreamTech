using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetAllProducts();

            return View(prodList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}