using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaProject0.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        //1.adım kontroller oluşturma
        //2.adım views oluşt
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
       
    }
}