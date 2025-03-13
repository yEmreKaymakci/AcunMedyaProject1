using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education

        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        public ActionResult Index()
        {
            var values = db.Tbl_Education.ToList();
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = db.Tbl_Education.Find(id);
            db.Tbl_Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateEducation(Tbl_Education education)
        {
            db.Tbl_Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}