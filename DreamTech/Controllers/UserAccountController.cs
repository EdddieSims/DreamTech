using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamTech.Controllers
{
    public class UserAccountController : BaseController
    {
        // GET: UserAccount
        public ActionResult Index()
        {
            return View();
        }
    }
}