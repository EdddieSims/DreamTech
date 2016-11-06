using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var repo = new Repos.CategoryRepo();
            var categoryList = repo.GetAllCategories();

            return View(categoryList);
        }
    }
}