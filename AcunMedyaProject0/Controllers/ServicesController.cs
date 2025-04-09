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
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities ();
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

        public ActionResult UpdateServices(int id)
        {
            var values = db.Tbl_Services.Find (id);
            return View(values);
        }
        [HttpPost]

        public ActionResult UpdateServices(Tbl_Services model)
        {
            var values = db.Tbl_Services.Find(model.ServicesID);
            values.Decription = model.Decription;
            values.Title = model.Title;
            values.IconUrl = model.IconUrl;
            values.Decription2 = model.Decription2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}