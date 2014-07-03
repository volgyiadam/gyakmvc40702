using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gyakmvc40702.Models
{
    public class gyakmvc40702Db : DbContext
    {
        //public gyakmvc40702Db() : base("server=DefaultConnection")
        //{
            
        //}
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    
}
}