using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuringTravelApi.Models
{
    public class TravelDocs
    {
        [Key]
        public int travelDocId { get; set; }

        public string hotelName { get; set; }

        public string roomCategory { get; set; }

        public string nameOfRep { get; set; }

        public string repHoursAtHotel { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime? DateofArrival { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime? DateofDeparture { get; set; }

        
        public int LengthOfStay { get; set; }

        public string returnFlightInfo { get; set; }

        
        public string Confirmation { get; set; }

        public string  timeOfPickUp { get; set; }







    }
}