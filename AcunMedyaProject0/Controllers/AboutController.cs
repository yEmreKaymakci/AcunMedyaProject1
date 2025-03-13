using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();

        public ActionResult Index()
        {
            var values = db.Tbl_About.ToList();
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateAbout(Tbl_About about)
        {
            db.Tbl_About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}