using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialTestomanial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = db.Tbl_Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.Tbl_Contact.ToList(); 
            return PartialView(values); 
        }
        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}