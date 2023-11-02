using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2Blank.Controllers {
    public class WeeksController : Controller {
        // GET: Weeks
        public ActionResult Index() {
            return View();
        }


        public ActionResult Saturday() {
            return View();
        }
        [HttpPost]
        public ActionResult Saturday(FormCollection col) {
            //ViewData["ButtonPressed"] = "Home pressed";
            if (col["btnSubmit"]=="submit") return RedirectToAction("Index");
            return View();
        }

        public ActionResult Sunday() {
            return View();
        }
        [HttpPost]
        public ActionResult Sunday(FormCollection col) {
            if (col["btnSubmit"] == "submit") return RedirectToAction("Index");
            return View();
        }

        public ActionResult Monday() {
            return View();
        }
        [HttpPost]
        public ActionResult Monday(FormCollection col) {
            if (col["btnSubmit"] == "submit") return RedirectToAction("Index");
            return View();
        }

        public ActionResult Tuesday() {
            return View();
        }
        [HttpPost]
        public ActionResult Tuesday(FormCollection col) {
            if (col["btnSubmit"] == "submit") return RedirectToAction("Index");
            return View();
        }

        public ActionResult Wednesday() {
            return View();
        }
        [HttpPost]
        public ActionResult Wednesday(FormCollection col) {
            if (col["btnSubmit"] == "submit") return RedirectToAction("Index");
            return View();
        }

        public ActionResult Thursday() {
            return View();
        }
        [HttpPost]
        public ActionResult Thursday(FormCollection col) {
            if (col["btnSubmit"] == "submit") return RedirectToAction("Index");
            return View();
        }

        public ActionResult Friday() {
            return View();
        }
        [HttpPost]
        public ActionResult Friday(FormCollection col) {
            if (col["btnSubmit"] == "submit") return RedirectToAction("Index");
            return View();
        }
    }
}