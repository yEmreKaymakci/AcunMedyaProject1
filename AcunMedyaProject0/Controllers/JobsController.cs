using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        public ActionResult Index()
        {
            var values = db.Tbl_Jobs.ToList();
            return View(values);
        }
        public ActionResult DeleteJobs(int id)
        {
            var values = db.Tbl_Jobs.Find(id);
            db.Tbl_Jobs.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateJobs()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateJobs(Tbl_Jobs jobs)
        {
            db.Tbl_Jobs.Add(jobs);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}