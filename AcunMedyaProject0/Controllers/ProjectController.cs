using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();
            return View(values);
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateProject(Tbl_Project project)
        {
            db.Tbl_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateProject(Tbl_Project model)
        {
            var values = db.Tbl_Project.Find(model.ProjectID);
            values.ProjectName = model.ProjectName;
            values.Description = model.Description;
            values.ProjectLink = model.ProjectLink;
            values.Image1 = model.Image1;
            values.Image2 = model.Image2;
            values.Image3 = model.Image3;
            values.CategoryID = model.CategoryID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}