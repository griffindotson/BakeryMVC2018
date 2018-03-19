using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryMVC2018.Models;

namespace BakeryMVC2018.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Purchase()
        {
            BakeryEntities db = new BakeryEntities();
            return View(db.Products.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "email,  phone")]Customer person)
        {
           

            return View("Purchase", person);

        }
    }
}