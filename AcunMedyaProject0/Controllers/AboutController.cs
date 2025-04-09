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
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

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

        public ActionResult UpdateAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(Tbl_About model)
        {
            var values = db.Tbl_About.Find(model.AboutID);
            values.ImageURL = model.ImageURL;
            values.Title = model.Title;
            values.BirthDay = model.BirthDay;
            values.WebSite = model.WebSite;
            values.Phone = model.Phone;
            values.City = model.City;
            values.Age = model.Age;
            values.Email = model.Email;
            values.FreeLance = model.FreeLance;
            values.Description1 = model.Description1;
            values.Description2 = model.Description2;
            values.Degree = model.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}