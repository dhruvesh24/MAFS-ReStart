﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }


        public void getImageURLs(){
            string name = FirstName + "-" + LastName;
            Image = name + ".png";
            Image2 = name + "2.png";
        }
        

    }
    
}