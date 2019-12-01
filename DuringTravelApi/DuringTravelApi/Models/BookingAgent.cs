using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuringTravelApi.Models
{
    public class BookingAgent
    {
        [Key]
        public int bookingAgentId { get; set; }

        public string bookingAgencyName { get; set; }
    }

}