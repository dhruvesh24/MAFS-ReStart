using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string BannerImg { get; set; }
    }
}