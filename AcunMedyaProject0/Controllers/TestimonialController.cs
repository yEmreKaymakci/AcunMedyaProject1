using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DbAcunMedyaProject1Entities db =  new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateTestimonial(Tbl_Testimonial testimonial) 
        {
            db.Tbl_Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            return View(values);
        }


        [HttpPost]
        public ActionResult UpdateTestimonial(Tbl_Testimonial model)
        {
            var value = db.Tbl_Testimonial.Find(model.TestimonialID);
            value.Description1 = model.Description1;
            value.TestimonialName = model.TestimonialName;
            value.Description2 = model.Description2;
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}