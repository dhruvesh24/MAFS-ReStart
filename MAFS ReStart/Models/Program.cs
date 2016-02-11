using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        //public string Tagline { get; set; }
        public string BannerImg { get; set; }
        //public ICollection<FundingAgency> Funders { get; set; }
        //public ICollection<Location> Locations { get; set; }

        public string RemoveSpaces(string name)
        {
            string temp = name;
            name.IndexOf('-');
            return temp;
        }

    }
}