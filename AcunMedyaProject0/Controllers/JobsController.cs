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
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
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

        public ActionResult UpdateJobs(int id)
        {
            var values = db.Tbl_Jobs.Find(id);
            return View(values);
        }
        [HttpPost]

        public ActionResult UpdateJobs(Tbl_Jobs model)
        {
            var values = db.Tbl_Jobs.Find(model.JobsID);
            values.Title = model.Title;
            values.StartDate = model.StartDate;
            values.EndDate = model.EndDate;
            values.CompanyName = model.CompanyName;
            values.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}