using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class Program
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public string FundingAgency { get; set; }
        public string Description { get; set; }
        public string Tagline { get; set; }
    //        • Title :: string
    //• Start Date :: DateTime
    //• End Date :: DateTime
    //• Recurs? :: Boolean
    //• Eligibility Requirements :: LinkedList<string>
    //• Founding Date :: DateTime
    //• Funding Agency :: LinkedList<string>
    //• Description :: string
    //• Tagline :: string

    }
}