﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject0.Models;

namespace AcunMedyaProject0.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1 ();
        public ActionResult Index()
        {
            var values = db.Tbl_Skill.ToList ();
            return View(values);
        }

        public ActionResult DeleteSkill(int id)
        {
            var values = db.Tbl_Skill.Find (id);
            db.Tbl_Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateSkill(Tbl_Skill skill)
        {
            db.Tbl_Skill.Add (skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}