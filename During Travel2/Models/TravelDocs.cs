using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace During_Travel2.Models
{
    public class TravelDocs
    {
        [Key]
        public int TraveldocsId { get; set; }

        [Display(Name = "Hotel")]
        public string Hotel { get; set; }

        [Display(Name = "Room Category")]
        public string RoomCategory { get; set; }

        [Display(Name = "Length Of Stay")]
        public  int Stay { get; set; }

        [Display(Name = "Name Of Representative")]
        public string nameOfRep { get; set; }

        [Display(Name = "Representative's hours at the hotel")]
        public string repHoursAtHotel { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Arrival")]
        public DateTime? DateOfArrival { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Departure")]
        public DateTime? DateOfDeparture { get; set; }

        [Display(Name = "Return Flight Information")]
        public string returnFlightInfo { get; set; }

        [Display(Name =" Confirmation #")]
        public string Confirmation { get; set; }

        [Display(Name = "Time of pick up ")]
        public string TimeofPickUp   { get; set; }







    }
}