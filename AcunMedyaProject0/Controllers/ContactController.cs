﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        public ActionResult Index()
        {
            var values = db.Tbl_Contact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateContact(Tbl_Contact contact)
        {
            db.Tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            return View(values);
        }
        [HttpPost]

        public ActionResult UpdateContact(Tbl_Contact model)
        {
            var values = db.Tbl_Contact.Find(model.ContactID);
            values.Description = model.Description;
            values.Address = model.Address;
            values.Email = model.Email;
            values.Phone = model.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}