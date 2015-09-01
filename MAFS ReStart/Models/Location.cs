using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{

    public class Location
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Zipcode { get; set; }
        public string GoogleMap { get; set; }
        public string Image { get; set; }

    }
}