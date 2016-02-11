using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MAFS_ReStart.Models
{
    public class MafsDb : DbContext
    {
        public MafsDb(): base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Fundraiser> Fundraisers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<FundingAgency> Funders { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}