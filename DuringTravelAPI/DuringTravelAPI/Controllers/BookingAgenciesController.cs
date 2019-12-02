using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DuringTravelAPI.Models;

namespace DuringTravelAPI.Controllers
{
    public class BookingAgenciesController : ApiController
    {
        private DuringTravelAPIContext db = new DuringTravelAPIContext();

        // GET: api/BookingAgencies
        public IQueryable<BookingAgency> GetBookingAgencies()
        {
            return db.BookingAgencies;
        }

        // GET: api/BookingAgencies/5
        [ResponseType(typeof(BookingAgency))]
        public async Task<IHttpActionResult> GetBookingAgency(int id)
        {
            BookingAgency bookingAgency = await db.BookingAgencies.FindAsync(id);
            if (bookingAgency == null)
            {
                return NotFound();
            }

            return Ok(bookingAgency);
        }

        // PUT: api/BookingAgencies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBookingAgency(int id, BookingAgency bookingAgency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bookingAgency.BookingAgencyId)
            {
                return BadRequest();
            }

            db.Entry(bookingAgency).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingAgencyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/BookingAgencies
        [ResponseType(typeof(BookingAgency))]
        public async Task<IHttpActionResult> PostBookingAgency(BookingAgency bookingAgency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BookingAgencies.Add(bookingAgency);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bookingAgency.BookingAgencyId }, bookingAgency);
        }

        // DELETE: api/BookingAgencies/5
        [ResponseType(typeof(BookingAgency))]
        public async Task<IHttpActionResult> DeleteBookingAgency(int id)
        {
            BookingAgency bookingAgency = await db.BookingAgencies.FindAsync(id);
            if (bookingAgency == null)
            {
                return NotFound();
            }

            db.BookingAgencies.Remove(bookingAgency);
            await db.SaveChangesAsync();

            return Ok(bookingAgency);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookingAgencyExists(int id)
        {
            return db.BookingAgencies.Count(e => e.BookingAgencyId == id) > 0;
        }
    }
}