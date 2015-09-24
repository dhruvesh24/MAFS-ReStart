using MAFS_ReStart.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAFS_ReStart.Controllers
{
    public class HomeController : Controller
    {
        private MafsDb _db = new MafsDb();

        public ActionResult Index(string searchTerm = null)
        {
            var model =
                //from r in _db.Restaurants
                //orderby r.Reviews.Average(review => review.Rating) descending
                //select new RestaurantListViewModel
                //{
                //    Id = r.Id,
                //    Name = r.Name,
                //    City = r.City,
                //    Country = r.Country,
                //    CountOfReviews = r.Reviews.Count()
                //};
                _db.Restaurants
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                .Take(10)
                .Select(r => new RestaurantListViewModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            CountOfReviews = r.Reviews.Count()
                        });

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Restaurants", model);
            }
            return View(model);
        }
        public ActionResult Test()
        {
            var model = _db;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Index2()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}::{1}  {2}", controller, action, id);
            ViewBag.Message = message;

            //var products = new System.Data.DataTable("teste");
            //products.Columns.Add("col1", typeof(int));
            //products.Columns.Add("col2", typeof(string));

            //products.Rows.Add(1, "product 1");
            //products.Rows.Add(2, "product 2");
            //products.Rows.Add(3, "product 3");
            //products.Rows.Add(4, "product 4");
            //products.Rows.Add(5, "product 5");
            //products.Rows.Add(6, "product 6");
            //products.Rows.Add(7, "product 7");


            //var grid = new GridView();
            //grid.DataSource = products;
            //grid.DataBind();

            //Response.ClearContent();
            //Response.Buffer = true;
            //Response.AddHeader("content-disposition", "attachment; filename=MyExcelFile.xls");
            //Response.ContentType = "application/ms-excel";

            //Response.Charset = "";
            //StringWriter sw = new StringWriter();
            //HtmlTextWriter htw = new HtmlTextWriter(sw);

            //grid.RenderControl(htw);

            //Response.Output.Write(sw.ToString());
            //Response.Flush();
            //Response.End();

            return View();
        }

        public ActionResult About2()
        {
            ViewBag.Message = "Your app description page.";
            var model = _db.Members.ToList();
            return View(model);
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Services2()
        {
            Random random = new Random();
            ViewBag.RandomNum = random.Next(9);
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(EmailResponse Response)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", Response);
            }
            else
            {
                return View();
            }
        }
        public ActionResult Error(string aspxerrorpath)
        {
            ViewBag.Page = aspxerrorpath;
            return View("~Shared/Error");
        }

        public ActionResult Locations()
        {
            var model = _db.Locations.ToList();
            return View(model);
        }
        public ActionResult Funders()
        {
            var model = _db.Funders.ToList();
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null){
                _db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
