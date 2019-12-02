using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DuringTravelAPI.Models
{
    public class DuringTravelAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DuringTravelAPIContext() : base("name=DuringTravelAPIContext")
        {
        }

        public System.Data.Entity.DbSet<DuringTravelAPI.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<DuringTravelAPI.Models.BookingAgency> BookingAgencies { get; set; }

        public System.Data.Entity.DbSet<DuringTravelAPI.Models.Destinations> Destinations { get; set; }

        public System.Data.Entity.DbSet<DuringTravelAPI.Models.TravelDocs> TravelDocs { get; set; }

        public System.Data.Entity.DbSet<DuringTravelAPI.Models.Vacation> Vacations { get; set; }
    }
}
