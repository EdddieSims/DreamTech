using System;
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
    }
}