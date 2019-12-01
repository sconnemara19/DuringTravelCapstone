namespace DuringTravelApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DuringTravelApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DuringTravelApi.Models.DuringTravelApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DuringTravelApi.Models.DuringTravelApiContext context)
        {
            context.Clients.AddOrUpdate(p => p.ClientId,
                new Client { ClientId = 1, Name = "Molly Kuether-Steele" },
                new Client { ClientId = 2, Name = "Andrea Houston" },
                new Client { ClientId = 3, Name = "Jennifer DiSalvo" },
                new Client { ClientId = 4, Name = " Amy Jacyna" },
                new Client { ClientId = 6, Name = "Rafael Connemara" },
                new Client { ClientId = 7, Name = " Angelo Connemara" }


            ); ;

            context.BookingAgents.AddOrUpdate(b => b.bookingAgentId,
                new BookingAgent { bookingAgentId = 1, bookingAgencyName = "Funjet Vacations" },
                new BookingAgent { bookingAgentId = 2, bookingAgencyName = "Southwest Vacations" },
                new BookingAgent { bookingAgentId = 3, bookingAgencyName = "United Vacations" }


                );
            context.Destinations.AddOrUpdate(d => d.DestinationId,
                new Destinations { DestinationId = 1, destinationName = "Cancun, Mexico" },
                new Destinations { DestinationId = 2, destinationName = "Punta Cana, Dominican Republic" },
                new Destinations { DestinationId = 3, destinationName = " Montego Bay,Jamaica " }
                );

            context.TravelDocs.AddOrUpdate(t => t.travelDocId,
                 new TravelDocs { travelDocId = 1, hotelName = "El Dorado Royale", roomCategory = "Ocean front", LengthOfStay = 7, nameOfRep = "Vanessa", repHoursAtHotel = "9am- 5pm", DateofArrival = new DateTime(2020, 2, 3), DateofDeparture = new DateTime(2020, 2, 10), returnFlightInfo = "AA2898 CUN/ORD 11:40am-2:30pm", timeOfPickUp = " 7:40am", Confirmation = "ABC123R7" },
                 new TravelDocs { travelDocId = 2, hotelName = " Now Jade Riviera Cancun", roomCategory = " Ocean view", LengthOfStay = 5, nameOfRep = "Jorge", repHoursAtHotel = "7am-2pm", DateofArrival = new DateTime(2020, 3, 5), DateofDeparture = new DateTime(2020, 3, 10), returnFlightInfo = "DL432 CUN/MKE 12:00pm -4:30pm", timeOfPickUp = " 8:00am", Confirmation = "DEF456S8" },
                 new TravelDocs { travelDocId = 3, hotelName = "Breathless Punta Cana", roomCategory = "Garden view", LengthOfStay = 7, nameOfRep = " Ricardo", repHoursAtHotel = "12pm-3pm", DateofArrival = new DateTime(2020, 11, 10), DateofDeparture = new DateTime(2020, 11, 18), returnFlightInfo = "WN498 PUJ/MSP 8:00am-1:00pm", timeOfPickUp = " 4:30am", Confirmation = "GHI789L9" },
                 new TravelDocs { travelDocId = 4, hotelName = "Barcelo Bavaro Palace", roomCategory = "Junior Suite Ocean Front", LengthOfStay = 5, nameOfRep = "Alejandro", repHoursAtHotel = "10am-3pm", DateofArrival = new DateTime(2020, 2, 18), DateofDeparture = new DateTime(2020, 2, 23), returnFlightInfo = "WN592 PUJ/MDW 5:00p-10:00p", timeOfPickUp = "1:00pm", Confirmation = "JKL101M6" },
                 new TravelDocs { travelDocId = 5, hotelName = "Secrets St. James Montego Bay", roomCategory = "Preferred Club Junior Suite Ocean View", LengthOfStay = 7, nameOfRep = "Olivia", repHoursAtHotel = "11am-1pm", DateofArrival = new DateTime(2020, 10, 8), DateofDeparture = new DateTime(2020, 10, 15), returnFlightInfo = "UA1211 MBJ/BOS 2:30pm-5:30pm", timeOfPickUp = "10:00am", Confirmation = "MNO121N4" },
                 new TravelDocs { travelDocId = 6, hotelName = "Breathless Montego Bay", roomCategory = "Xhale Club Junior Suite Swim up", LengthOfStay = 5, nameOfRep = "Jay", repHoursAtHotel = "8am-4pm", DateofArrival = new DateTime(2020, 12, 23), DateofDeparture = new DateTime(2020, 12, 28), returnFlightInfo = "AA1492 MBJ/MSN  1:15 -5:15pm", timeOfPickUp = " 11:00am ", Confirmation = "PQR121T2" }












                );


        }
    }
}
