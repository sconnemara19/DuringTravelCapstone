using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuringTravelApi.Models
{
    public class Destinations
    {
        [Key]
        public int DestinationId { get; set; }

        public string destinationName { get; set; }


    }
}