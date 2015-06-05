using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class Fundraiser
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsMini { get; set; }
        public string Location { get; set; }
        public string Venue { get; set; }
        public string Intro { get; set; }
        public string WriteUp { get; set; }
        public string CoverPhoto { get; set; }
        public string IssuuLink { get; set; }
        public string FlickrGallery { get; set; }
    }
}