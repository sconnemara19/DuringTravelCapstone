using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DuringTravelAPI.Models
{
    public class Vacation
    {
        [Key]
        public int VacationId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("TravelDocs")]
        public int TraveldocsId { get; set; }
        public TravelDocs TravelDocs { get; set; }
    }

}