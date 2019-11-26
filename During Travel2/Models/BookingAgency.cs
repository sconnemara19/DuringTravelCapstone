using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace During_Travel2.Models
{
    public class BookingAgency
    {
        [Key]
        public int BookingAgencyId { get; set; }

        [Display(Name = "Booking Agencies")]
        public string bookingAgencyName { get; set; }

    }
}