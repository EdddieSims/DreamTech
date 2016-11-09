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
            return View(getAll());
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

        public ActionResult AddProdToCart(int? id)
        {
            var cartObject = (Session["CartItems"] as List<int?>) ?? new List<int?>();
            cartObject.Add(id);

            Session["CartItems"] = cartObject;

            return View("Index", getAll());
        }

        public ActionResult AddProdToWish(int? id)
        {
            var wishObject = (Session["WishItems"] as List<int?>) ?? new List<int?>();
            wishObject.Add(id);

            Session["WishItems"] = wishObject;

            return View("../Home/Index", getAll());
        }

        public ActionResult Country()
        {
            ViewBag.Message = "Country List";

            var repo = new Repos.CountryRepo();
            var countryList = repo.GetAllCountries();

            return View(countryList);
        }

        public ActionResult Form(string name)
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetProductByName(name);

            return View("Index", prodList);
        }

        public List<console.Models.tblProduct> getAll()
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetAllProducts();

            return prodList;
        }
    }
}