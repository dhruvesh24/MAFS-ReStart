﻿using MAFS_ReStart.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        //public ActionResult Index2()
        //{
        //    var controller = RouteData.Values["controller"];
        //    var action = RouteData.Values["action"];
        //    var id = RouteData.Values["id"];
        //    var message = String.Format("{0}::{1}  {2}", controller, action, id);
        //    ViewBag.Message = message;

        //    //var products = new System.Data.DataTable("teste");
        //    //products.Columns.Add("col1", typeof(int));
        //    //products.Columns.Add("col2", typeof(string));

        //    //products.Rows.Add(1, "product 1");
        //    //products.Rows.Add(2, "product 2");
        //    //products.Rows.Add(3, "product 3");
        //    //products.Rows.Add(4, "product 4");
        //    //products.Rows.Add(5, "product 5");
        //    //products.Rows.Add(6, "product 6");
        //    //products.Rows.Add(7, "product 7");


        //    //var grid = new GridView();
        //    //grid.DataSource = products;
        //    //grid.DataBind();

        //    //Response.ClearContent();
        //    //Response.Buffer = true;
        //    //Response.AddHeader("content-disposition", "attachment; filename=MyExcelFile.xls");
        //    //Response.ContentType = "application/ms-excel";

        //    //Response.Charset = "";
        //    //StringWriter sw = new StringWriter();
        //    //HtmlTextWriter htw = new HtmlTextWriter(sw);

        //    //grid.RenderControl(htw);

        //    //Response.Output.Write(sw.ToString());
        //    //Response.Flush();
        //    //Response.End();

        //    return View();
        //}

        public ActionResult Board()
        {
            ViewBag.Message = "Your app description page.";
            //var model = _db.Members.ToList();
            var model = _db.Members.Where(r => r.IsActive == true && r.IsStaff == false);

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
            //Validate Google ReCaptcha
            var reCaptchaResponse = Request["g-recaptcha-response"];
            string secretKey = "6Lfpw0sUAAAAAInEL5B4PXTOqDwMS1D5zL9PQQrR";
            var client = new WebClient();
            var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, reCaptchaResponse));
            var obj = JObject.Parse(result);
            var reCaptchaStatus = (bool)obj.SelectToken("success");
            ViewBag.reCaptchaMessage = reCaptchaStatus ? "Success" : "Failed";

            if (ModelState.IsValid && reCaptchaStatus)
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
            var model = _db.Locations.OrderBy(r => r.CityName);
            return View(model);
        }
        public ActionResult Funders()
        {
            var model = _db.Funders.OrderBy(r => r.Name);
            return View(model);
        }

        //Partial menu views
        public ActionResult getProgramMenu()
        {
            var model = _db.Programs.Where(r => r.Icon != null);
            return PartialView("_ProgramMenu", model);
        }
        //Partial fundraiser views
        public ActionResult getFundraiserMenu()
        {
            var model = _db.Fundraisers.OrderByDescending(r => r.Date);

            return PartialView("_FundraiserMenu", model);
        }
        public ActionResult getRandomFunder()
        {

            var funders = _db.Funders.OrderBy(r => r.Name); //get the funders
            
            var temp = new LinkedList<FundingAgency>();     //add to a linkedlist
            foreach(var funder in funders){                 //add to a linkedlist
                temp.AddLast(funder);
            }
            temp.Take(4);
            var model = new LinkedList<FundingAgency>();    //the final model

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, temp.Count());
                //model.AddLast(funders.ElementAt(index));
                //TO DO
                model.AddLast(temp.ElementAt(index));
                temp.Remove(temp.ElementAt(index));
            }

            return PartialView("_RandomFunder", model);
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
