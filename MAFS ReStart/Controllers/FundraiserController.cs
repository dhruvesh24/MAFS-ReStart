using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MAFS_ReStart.Models;

namespace MAFS_ReStart.Controllers
{
    public class FundraiserController : Controller
    {
        private MafsDb db = new MafsDb();

        //
        // GET: /Fundraiser/

        public ActionResult Index()
        {
            return View(db.Fundraisers.ToList().OrderByDescending(r => r.Date));
        }

        public ActionResult Mini2017()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View(db.Fundraisers.ToList().OrderByDescending(r => r.Date.Year));
        }

        //
        // GET: /Fundraiser/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.First = db.Fundraisers.Max(r => r.Date.Year);
            ViewBag.Last = db.Fundraisers.Min(r => r.Date.Year);
            Fundraiser fundraiser = db.Fundraisers.Find(id);
            if (fundraiser == null)
            {
                return HttpNotFound();
            }
            return View(fundraiser);
        }
        public ActionResult Details2(int id = 0)
        {
            ViewBag.First = db.Fundraisers.Max(r => r.Date.Year);
            ViewBag.Last = db.Fundraisers.Min(r => r.Date.Year);
            Fundraiser fundraiser = db.Fundraisers.Find(id);
            if (fundraiser == null)
            {
                return HttpNotFound();
            }
            return View(fundraiser);
        }

        //
        // GET: /Fundraiser/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Fundraiser/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Fundraiser fundraiser)
        {
            if (ModelState.IsValid)
            {
                db.Fundraisers.Add(fundraiser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fundraiser);
        }

        //
        // GET: /Fundraiser/Edit/5
        [Authorize]
        public ActionResult Edit(int id = 0)
        {
            Fundraiser fundraiser = db.Fundraisers.Find(id);
            if (fundraiser == null)
            {
                return HttpNotFound();
            }
            return View(fundraiser);
        }

        //
        // POST: /Fundraiser/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(Fundraiser fundraiser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fundraiser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fundraiser);
        }

        //
        // GET: /Fundraiser/Delete/5
        [Authorize]
        public ActionResult Delete(int id = 0)
        {
            Fundraiser fundraiser = db.Fundraisers.Find(id);
            if (fundraiser == null)
            {
                return HttpNotFound();
            }
            return View(fundraiser);
        }


        //
        // POST: /Fundraiser/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Fundraiser fundraiser = db.Fundraisers.Find(id);
            db.Fundraisers.Remove(fundraiser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Partial menu views
        public ActionResult getOtherFundraisers(int id)
        {
            var model = db.Fundraisers.OrderByDescending(r => r.Date)
                                      .Where(r => r.Id != id)
                                      .Take(3);
            return PartialView("_OtherFundraisers", model);
        }

        public ActionResult getPrev(int id)
        {   
            Fundraiser model = null;
            
            var fundraisers = db.Fundraisers.OrderBy(r => r.Date);
            
            DateTime Date = db.Fundraisers.Find(id).Date;
            
            if(Date == fundraisers.First().Date){
                model = null;
                return PartialView("_PrevFundraiserButton", model);
            }

            fundraisers = db.Fundraisers.OrderByDescending(r => r.Date);
            foreach(var fundraiser in fundraisers){
                if (fundraiser.Date < Date){
                    model = fundraiser;
                    break;
                }
            }
            return PartialView("_PrevFundraiserButton", model);
        }
        public ActionResult getNext(int id)
        {
            Fundraiser model = null;

            var fundraisers = db.Fundraisers.OrderByDescending(r => r.Date);

            DateTime Date = db.Fundraisers.Find(id).Date;

            if (Date == fundraisers.First().Date)
            {
                model = null;
                return PartialView("_NextFundraiserButton", model);
            }

            fundraisers = db.Fundraisers.OrderBy(r => r.Date);
            foreach (var fundraiser in fundraisers)
            {
                if (fundraiser.Date > Date)
                {
                    model = fundraiser;
                    break;
                }
            }
            return PartialView("_NextFundraiserButton", model);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        
    }
}