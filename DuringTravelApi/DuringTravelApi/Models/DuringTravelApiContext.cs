using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DuringTravelApi.Models
{
    public class DuringTravelApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DuringTravelApiContext() : base("name=DuringTravelApiContext")
        {
        }

        public System.Data.Entity.DbSet<DuringTravelApi.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<DuringTravelApi.Models.BookingAgent> BookingAgents { get; set; }

        public System.Data.Entity.DbSet<DuringTravelApi.Models.Destinations> Destinations { get; set; }

        public System.Data.Entity.DbSet<DuringTravelApi.Models.TravelDocs> TravelDocs { get; set; }
    }
}
