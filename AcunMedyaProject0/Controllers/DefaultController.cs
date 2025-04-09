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
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
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

        public PartialViewResult PartialSlider()
        {
            var values = db.Tbl_Slider.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Tbl_Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSumaryContact()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSumaryName()
        {
            var values = db.Tbl_Slider.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = db.Tbl_Education.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialJobs()
        {
            var values = db.Tbl_Jobs.ToList();
            return PartialView(values);
        }

        public ActionResult PartialPortfolio()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView(values);
        }

    }
}