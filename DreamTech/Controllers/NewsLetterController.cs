using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class NewsLetterController : BaseController
    {
        // GET: NewsLetter
        public ActionResult Index()
        {
            var repo = new Repos.OptInTypeRepo();
            var OptList = repo.GetAllOptTypes();

            return View(OptList);
        }
    }
}