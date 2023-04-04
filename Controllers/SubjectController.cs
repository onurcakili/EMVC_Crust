﻿using EFMVC_odev.Context;
using EFMVC_odev.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC_odev.Controllers
{
    public class SubjectController : Controller
    {

        MVCContext db;

        public SubjectController(MVCContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList(); 
            return View(subjects);
        }

        public IActionResult Delete(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);

            if(subject != null)
            {
                db.Remove(subject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
