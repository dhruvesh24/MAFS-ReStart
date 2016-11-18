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
            var model = _db.Programs.Take(3);
            return PartialView("_ProgramTile", model);
        }

        public ActionResult Nutrition()
        {
            var model = _db.Programs.Find(3);
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
