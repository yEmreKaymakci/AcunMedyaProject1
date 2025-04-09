using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities ();
        public ActionResult Index()
        {
            var values = db.Tbl_Message.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = db.Tbl_Message.Find(id);
            db.Tbl_Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateMessage(int id)
        {
            var values = db.Tbl_Message.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateMessage(Tbl_Message model)
        {
            var values = db.Tbl_Message.Find(model.MessageID);
            values.NameSurname = model.NameSurname;
            values.Mail = model.Mail;
            values.Subject = model.Subject;
            values.MessageContent = model.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}