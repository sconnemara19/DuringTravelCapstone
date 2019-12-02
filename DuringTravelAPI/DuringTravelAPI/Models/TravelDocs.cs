using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuringTravelAPI.Models
{
    public class TravelDocs
    {
        [Key]
        public int TraveldocsId { get; set; }

        
        public string Hotel { get; set; }

        
        public string RoomCategory { get; set; }

        
        public int Stay { get; set; }

        
        public string nameOfRep { get; set; }

        
        public string repHoursAtHotel { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfArrival { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfDeparture { get; set; }

        
        public string returnFlightInfo { get; set; }

        
        public string Confirmation { get; set; }

        
        public string TimeofPickUp { get; set; }
    }
}