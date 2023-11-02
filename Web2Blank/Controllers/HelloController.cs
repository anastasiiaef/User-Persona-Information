using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2Blank.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection col) {

            ViewData["FavoriteFood"] = col["txtFav1"];

            switch (col["btnSubmit"]) {
                case "save":
                    ViewData["ButtonPressed"] = "Save button pressed";
                    break;
                case "delete":
                    ViewData["ButtonPressed"] = "Delete button pressed";
                    break;
                case "redirect":

                    if (col["chkClickMe"].ToString().Contains("true")) return RedirectToAction("Family");
                    return RedirectToAction("Friends");

                case "close":
                    ViewData["ButtonPressed"] = "Close button pressed";
                    break;             
            }
            return View();
        }
        public ActionResult Family() {
            return View();
        }

        public ActionResult Friends() {
            return View();
        }
    }
}