using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DuringTravelApi.Models;

namespace DuringTravelApi.Controllers
{
    public class BookingAgentsController : ApiController
    {
        private DuringTravelApiContext db = new DuringTravelApiContext();

        // GET: api/BookingAgents
        public IQueryable<BookingAgent> GetBookingAgents()
        {
            return db.BookingAgents;
        }

        // GET: api/BookingAgents/5
        [ResponseType(typeof(BookingAgent))]
        public IHttpActionResult GetBookingAgent(int id)
        {
            BookingAgent bookingAgent = db.BookingAgents.Find(id);
            if (bookingAgent == null)
            {
                return NotFound();
            }

            return Ok(bookingAgent);
        }

        // PUT: api/BookingAgents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBookingAgent(int id, BookingAgent bookingAgent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bookingAgent.bookingAgentId)
            {
                return BadRequest();
            }

            db.Entry(bookingAgent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingAgentExists(id))
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

        // POST: api/BookingAgents
        [ResponseType(typeof(BookingAgent))]
        public IHttpActionResult PostBookingAgent(BookingAgent bookingAgent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BookingAgents.Add(bookingAgent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bookingAgent.bookingAgentId }, bookingAgent);
        }

        // DELETE: api/BookingAgents/5
        [ResponseType(typeof(BookingAgent))]
        public IHttpActionResult DeleteBookingAgent(int id)
        {
            BookingAgent bookingAgent = db.BookingAgents.Find(id);
            if (bookingAgent == null)
            {
                return NotFound();
            }

            db.BookingAgents.Remove(bookingAgent);
            db.SaveChanges();

            return Ok(bookingAgent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookingAgentExists(int id)
        {
            return db.BookingAgents.Count(e => e.bookingAgentId == id) > 0;
        }
    }
}