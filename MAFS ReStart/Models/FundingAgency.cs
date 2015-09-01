using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class FundingAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortBio { get; set; }
        public string URL { get; set; }
        public string ImageURL { get; set; }
        public int ImageWidth { get; set; }
    }
}