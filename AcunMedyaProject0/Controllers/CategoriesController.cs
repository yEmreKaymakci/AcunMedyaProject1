using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories MVC MODEL VİEW CONTROLLER 

        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();

        public ActionResult Index()
        {
            //string byte int liste(var : sağ tarafta hangi değişken türü varsa onun gibi davranıyor)
            var values = db.Tbl_Category.ToList();//select * from Tbl_Category
            return View(values);
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);//5
            db.Tbl_Category.Remove(values);//delete
            db.SaveChanges();//sql deki control + s
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
           return View();
        }
        [HttpPost]

        public ActionResult CreateCategory(Tbl_Category category) //category id = , categoryname = test
        {
            db.Tbl_Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCategory(int id) 
        {
            var values = db.Tbl_Category.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category model)
        {
            var values = db.Tbl_Category.Find(model.CategoryID);
            values.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Get Post

    }
}