﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(int? id)
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetAllProducts();

            if(id != null)
            {
                AddProd(id);
            }

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

        public void AddProd(int? id)
        {
            var cartObject = (Session["CartItems"] as List<int?>) ?? new List<int?>();
            cartObject.Add(id);

            Session["CartItems"] = cartObject;
        }

        public ActionResult Country()
        {
            ViewBag.Message = "Country List";

            var repo = new Repos.CountryRepo();
            var countryList = repo.GetAllCountries();

            return View(countryList);
        }
    }
}