using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models; 


namespace AcunMedyaProject0.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1 ();
        public ActionResult Index()
        {
            var values = db.Tbl_Services.ToList ();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.Tbl_Services.Find (id);
            db.Tbl_Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateServices(Tbl_Services services)
        {
            db.Tbl_Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}