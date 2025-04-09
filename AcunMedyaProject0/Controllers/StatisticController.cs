using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities ();
        public ActionResult Index()
        {
            //ViewBag
            ViewBag.LastCategory = db.Tbl_Category.OrderByDescending(c => c.CategoryID).Select(c => c.CategoryName).FirstOrDefault();
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            
            ViewBag.TestimonialCount = db.Tbl_Testimonial.Count();
            ViewBag.LastTestimonial = db.Tbl_Testimonial.OrderByDescending(c => c.TestimonialID).Select(c => c.TestimonialName).FirstOrDefault();

            ViewBag.ProjectCount = db.Tbl_Project.Count();
            ViewBag.LastProject = db.Tbl_Project.OrderByDescending(c => c.ProjectID).Select(c => c.ProjectName).FirstOrDefault();

            ViewBag.EducationCount = db.Tbl_Education.Count();
            ViewBag.LastEducation = db.Tbl_Education.OrderByDescending(c => c.EducationID).Select(c => c.Section).FirstOrDefault();

            ViewBag.JobsCount = db.Tbl_Jobs.Count();
            ViewBag.LastJobs = db.Tbl_Jobs.OrderByDescending(c => c.JobsID).Select(c => c.CompanyName).FirstOrDefault();

            ViewBag.MessageCount = db.Tbl_Message.Count();
            ViewBag.LastMessage = db.Tbl_Message.OrderByDescending(c => c.MessageID).Select(c => c.MessageContent).FirstOrDefault();

            ViewBag.ServicesCount = db.Tbl_Services.Count();
            ViewBag.LastServices = db.Tbl_Services.OrderByDescending(c => c.ServicesID).Select(c => c.Title).FirstOrDefault();

            ViewBag.SkillCount = db.Tbl_Skill.Count();
            ViewBag.LastSkillt = db.Tbl_Skill.OrderByDescending(c => c.SkillID).Select(c => c.SkillName).FirstOrDefault();
            return View();
        }
    }
}