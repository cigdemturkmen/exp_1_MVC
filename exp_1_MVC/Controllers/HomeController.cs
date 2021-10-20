using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exp_1_MVC.Controllers
{
    public class HomeController : Controller  //Home - controllerin adı. home controllerın içindeki index'i çalıştırma.
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}