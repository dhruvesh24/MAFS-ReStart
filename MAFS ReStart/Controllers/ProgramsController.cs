using MAFS_ReStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAFS_ReStart.Controllers
{
    public class ProgramsController : Controller
    {
        //
        // GET: /Programs/
        private MafsDb _db = new MafsDb();
        public ActionResult Index(string ProgramName = null)
        {
            if (ProgramName == null)
            {
                return View("All");
            }
            Program model = null;
            foreach (Program program in _db.Programs)
            {
                if (program.Title == ProgramName)
                {
                    model = program;
                    break;
                }
            }
            if (model == null)
            {
                return View("All");
            }

            ViewBag.Name = RouteData.Values["ProgramName"];
            return View(model);
        }
        public ActionResult All()
        {
            return View();
        }

    }
}
