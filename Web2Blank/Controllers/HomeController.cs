using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2Blank.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Models.User u = new Models.User();
            u.FirstName = "Anastasiia";
            u.LastName = "Efimova";
            u.UserID = "aefimova@gmail";
            u.Password = "123";

            return View(u);
        }
    }
}