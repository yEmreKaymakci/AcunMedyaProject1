using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;


namespace AcunMedyaProject0.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1(); 
        public ActionResult Index()
        {
            var values = db.Tbl_Slider.ToList();
            return View(values);
        }

        public ActionResult DeleteSlider(int id)
        {
            var values =db.Tbl_Slider.Find(id);
            db.Tbl_Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSlider(Tbl_Slider slider)
        {
            db.Tbl_Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateSlider(int id)
        {
            var values = db.Tbl_Slider.Find(id);
            return View(values);
        }
        [HttpPost]

        public ActionResult UpdateSlider(Tbl_Slider model)
        {
            var values = db.Tbl_Slider.Find(model.SliderID);
            values.NameSurname = model.NameSurname;
            values.Description = model.Description;
            values.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}