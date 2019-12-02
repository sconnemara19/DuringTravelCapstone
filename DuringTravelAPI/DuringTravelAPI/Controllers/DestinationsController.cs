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
    public class DestinationsController : ApiController
    {
        private DuringTravelAPIContext db = new DuringTravelAPIContext();

        // GET: api/Destinations
        public IQueryable<Destinations> GetDestinations()
        {
            return db.Destinations;
        }

        // GET: api/Destinations/5
        [ResponseType(typeof(Destinations))]
        public async Task<IHttpActionResult> GetDestinations(int id)
        {
            Destinations destinations = await db.Destinations.FindAsync(id);
            if (destinations == null)
            {
                return NotFound();
            }

            return Ok(destinations);
        }

        // PUT: api/Destinations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDestinations(int id, Destinations destinations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != destinations.DestinationId)
            {
                return BadRequest();
            }

            db.Entry(destinations).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinationsExists(id))
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

        // POST: api/Destinations
        [ResponseType(typeof(Destinations))]
        public async Task<IHttpActionResult> PostDestinations(Destinations destinations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Destinations.Add(destinations);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = destinations.DestinationId }, destinations);
        }

        // DELETE: api/Destinations/5
        [ResponseType(typeof(Destinations))]
        public async Task<IHttpActionResult> DeleteDestinations(int id)
        {
            Destinations destinations = await db.Destinations.FindAsync(id);
            if (destinations == null)
            {
                return NotFound();
            }

            db.Destinations.Remove(destinations);
            await db.SaveChangesAsync();

            return Ok(destinations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DestinationsExists(int id)
        {
            return db.Destinations.Count(e => e.DestinationId == id) > 0;
        }
    }
}