using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace During_Travel2.Models
{
    public class Destinations
    {
        [Key]
        public int DestinationId { get; set; }

        [Display (Name = " Destination Name")]
        public string destinationName { get; set; }

    }
}