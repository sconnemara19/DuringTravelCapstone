namespace During_Travel2.Migrations
{
    using During_Travel2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<During_Travel2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(During_Travel2.Models.ApplicationDbContext context)
        {
            context.Clients.AddOrUpdate(x => x.ClientId,
                new Client { ClientId = 1, Name = "Molly Kuether-Steele" },
                new Client { ClientId = 2, Name = "Andrea Houston" },
                new Client { ClientId = 3, Name = "Jennifer DiSalvo" },
                new Client { ClientId = 4, Name = " Amy Jacyna" },
                new Client { ClientId = 6, Name = "Rafael Connemara" },
                new Client { ClientId = 7, Name = " Angelo Connemara" }

                 );

            context.TravelDocs.AddOrUpdate(t => t.TraveldocsId,
                 new TravelDocs { TraveldocsId = 1, Hotel = "El Dorado Royale", RoomCategory = "Ocean front", Stay = 7, nameOfRep = "Vanessa", repHoursAtHotel = "9am- 5pm", DateOfArrival = new DateTime(2020, 2, 3), DateOfDeparture = new DateTime(2020, 2, 10), returnFlightInfo = "AA2898 CUN/ORD 11:40am-2:30pm", TimeofPickUp = " 7:40am", Confirmation = "ABC123R7" },
                 new TravelDocs { TraveldocsId = 2, Hotel = " Now Jade Riviera Cancun", RoomCategory = " Ocean view", Stay = 5, nameOfRep = "Jorge", repHoursAtHotel = "7am-2pm", DateOfArrival = new DateTime(2020, 3, 5), DateOfDeparture = new DateTime(2020, 3, 10), returnFlightInfo = "DL432 CUN/MKE 12:00pm -4:30pm", TimeofPickUp = " 8:00am", Confirmation = "DEF456S8" },
                 new TravelDocs { TraveldocsId = 3, Hotel = "Breathless Punta Cana", RoomCategory = "Garden view", Stay = 7, nameOfRep = " Ricardo", repHoursAtHotel = "12pm-3pm", DateOfArrival = new DateTime(2020, 11, 10), DateOfDeparture = new DateTime(2020, 11, 18), returnFlightInfo = "WN498 PUJ/MSP 8:00am-1:00pm", TimeofPickUp = " 4:30am", Confirmation = "GHI789L9" },
                 new TravelDocs { TraveldocsId = 4, Hotel = "Barcelo Bavaro Palace", RoomCategory = "Junior Suite Ocean Front", Stay = 5, nameOfRep = "Alejandro", repHoursAtHotel = "10am-3pm", DateOfArrival = new DateTime(2020, 2, 18), DateOfDeparture = new DateTime(2020, 2, 23), returnFlightInfo = "WN592 PUJ/MDW 5:00p-10:00p", TimeofPickUp = "1:00pm", Confirmation = "JKL101M6" },
                 new TravelDocs { TraveldocsId = 5, Hotel = "Secrets St. James Montego Bay", RoomCategory = "Preferred Club Junior Suite Ocean View", Stay = 7, nameOfRep = "Olivia", repHoursAtHotel = "11am-1pm", DateOfArrival = new DateTime(2020, 10, 8), DateOfDeparture = new DateTime(2020, 10, 15), returnFlightInfo = "UA1211 MBJ/BOS 2:30pm-5:30pm", TimeofPickUp = "10:00am", Confirmation = "MNO121N4" },
                 new TravelDocs { TraveldocsId = 6, Hotel = "Breathless Montego Bay", RoomCategory = "Xhale Club Junior Suite Swim up", Stay = 5, nameOfRep = "Jay", repHoursAtHotel = "8am-4pm", DateOfArrival = new DateTime(2020, 12, 23), DateOfDeparture = new DateTime(2020, 12, 28), returnFlightInfo = "AA1492 MBJ/MSN  1:15 -5:15pm", TimeofPickUp = " 11:00am ", Confirmation = "PQR121T2" }


                );

            context.Vacations.AddOrUpdate(v => v.VacationId,
                new Vacation { VacationId = 1, ClientId = 6, TraveldocsId = 1 },
                new Vacation { VacationId = 2, ClientId = 1, TraveldocsId = 4 },
                new Vacation { VacationId = 3, ClientId = 2, TraveldocsId = 5 },
                new Vacation { VacationId = 4, ClientId = 3, TraveldocsId = 3 },
                new Vacation { VacationId = 5, ClientId = 4, TraveldocsId = 2 },
                new Vacation { VacationId = 6, ClientId = 5, TraveldocsId = 6 }

            );




        }
    }
}
