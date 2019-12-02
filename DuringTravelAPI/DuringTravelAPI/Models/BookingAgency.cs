using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuringTravelAPI.Models
{
    public class BookingAgency
    {
        [Key]
        public int BookingAgencyId { get; set; }

        public string bookingAgencyName { get; set; }

    }
}