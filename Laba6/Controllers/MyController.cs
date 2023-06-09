using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laba6.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /My/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(decimal salary, string lastName, int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Id = id;
            ViewBag.Salary = salary;
            ViewBag.LastName = lastName;
            ViewBag.Name = Request.Form["name"];
            ViewBag.Patronymic = Request.Form["patronymic"];

            return View("NewView");
        }
    }
}
