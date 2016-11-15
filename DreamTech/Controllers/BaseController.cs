﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using console.Models;

namespace DreamTech.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        private List<tblCountry> _countries;
        protected List<tblCountry> Countries
        {
            get
            {
                var repo = new Repos.CountryRepo();
                _countries = repo.GetAllCountries();

                return _countries;
            }
        }

        private List<tblProductCategory> _categories;
        protected List<tblProductCategory> Categories
        {
            get
            {
                var repo = new Repos.CategoryRepo();
                _categories = repo.GetAllCategories();

                return _categories;
            }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.BaseCountries = Countries;
            ViewBag.BaseCategories = Categories;

            base.OnActionExecuting(filterContext);
        }

        public void  getSession()
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetAllProducts();

            Session["CartItems"] = prodList;
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

            return View("Index", getAll());
        }

        public List<console.Models.tblProduct> getAll()
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetAllProducts();

            return prodList;
        }

        [HttpPost]
        public ActionResult SearchByName(string name)
        {
            var repo = new Repos.ProductRepo();
            var prodList = repo.GetProductByName(name);

            return View("../Product/Index", prodList);
        }

        public List<console.Models.tblProduct> getFeaturedProd(List<console.Models.tblFeaturedProduct> prod)
        {
            List<console.Models.tblProduct> prodList;
            List<int?> allId = new List<int?>();

            foreach (var prodId in prod)
            {
                allId.Add(prodId.product_id);
            }

            var repo = new Repos.ProductRepo();
            prodList = repo.GetMutipleProducts(allId);

            return prodList;
        }
    }
}