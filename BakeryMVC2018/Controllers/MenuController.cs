using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryMVC2018.Models;

namespace BakeryMVC2018.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            BakeryEntities db = new BakeryEntities();
            return View(db.Products.ToList());

        }
    }
}