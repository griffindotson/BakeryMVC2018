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
            return View();
        }

        public ActionResult Receipt(Order ord)
        {

            return View(ord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public ActionResult Index([Bind(Include = "email,  phone,"+
             "GlazedDonut_Quantity, MapleBar_Quantity," +
            "CinnamonRoll_Quantity, Brownie_Quantity, Danish_Quantity," +
            "DripCoffee_Quantity, Americano_Quantity, Latte_Quantity, SliceOfPie_Quantity, DeliSandwhich_Quantity")]Order person)
        {
            if(Session["shopper"] == null)
            {
                Session["shopper"] = person.Email;
                return View("Purchase");
            }
            else
            {
                return View("receipt", person);
            }          
        }
    }
}