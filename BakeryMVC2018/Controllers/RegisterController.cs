using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryMVC2018.Models;

namespace BakeryMVC2018.Controllers
{
    public class RegisterController : Controller
    {
        BakeryEntities db = new BakeryEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "lastName, firstName, email,  phone")]NewPerson person)
        {
            Person p = new Person();
            p.PersonLastName = person.LastName;
            p.PersonFirstName = person.FirstName;
            p.PersonEmail = person.Email;
            p.PersonPhone = person.Phone;
            p.PersonDateAdded = DateTime.Now;

            db.People.Add(p);
            db.SaveChanges();

            return View("Confirmation");

        }
    }
}