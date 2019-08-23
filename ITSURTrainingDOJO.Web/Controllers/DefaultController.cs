using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITSURTrainingDOJO.Web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            Session.Add("logged", true);
            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Session.Remove("logged");
            return RedirectToAction("Index");
        }
    }
}