using MAFS_ReStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAFS_ReStart.Controllers
{
    public class ProgramController : Controller
    {
        //
        // GET: /Programs/
        private MafsDb _db = new MafsDb();
        public ActionResult Index()
        {
            var model = _db.Programs.ToList();
           // ViewBag.Name = RouteData.Values["ProgramName"];
            return View(model);
        }
        public ActionResult Info([Bind(Prefix="Id")]string ProgramName)
        {
            if (ProgramName == null)
            {
                return RedirectToAction("Index");
            }
            Program model = null;
            foreach (Program program in _db.Programs)
            {
                if (program.Title == ProgramName)
                {
                    model = program;
                    return View(model);
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult getProgramTile()
        {
            var model = _db.Programs.Where(r => r.Icon != null);
            return PartialView("_ProgramTile", model);
        }

        public ActionResult Nutrition()
        {
            var programs = _db.Programs.Where(r => r.Title.Equals("Nutrition"));
            Program model = programs.First();
            return View(model);
        }
        public ActionResult PublicBenefits()
        {
            var programs = _db.Programs.Where(r => r.Title.Equals("Public-Benefits"));
            Program model = programs.First();
            return View(model);
        }
        public ActionResult HealthResearch()
        {
            var programs = _db.Programs.Where(r => r.Title.Equals("Health-Research"));
            Program model = programs.First();
            return View(model);
        }
        public ActionResult Education()
        {
            var programs = _db.Programs.Where(r => r.Title.Equals("Education"));
            Program model = programs.First();
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }


    }

}
