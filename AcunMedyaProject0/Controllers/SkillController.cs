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
        
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities ();
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

        public ActionResult UpdateSkill(int id)
        {
            var values = db.Tbl_Skill.Find(id);
            return View(values);
        }
        [HttpPost]

        public ActionResult UpdateSkill(Tbl_Skill model)
        {
            var values = db.Tbl_Skill.Find(model.SkillID);
            values.SkillName = model.SkillName;
            values.Percentage = model.Percentage;
            values.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}