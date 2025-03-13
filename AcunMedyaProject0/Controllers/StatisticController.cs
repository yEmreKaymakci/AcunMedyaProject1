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
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1 ();
        public ActionResult Index()
        {
            //ViewBag
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            ViewBag.TestimonialCount = db.Tbl_Testimonial.Count();
            ViewBag.ProjectCount = db.Tbl_Project.Count();

            return View();
        }
    }
}