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
    public class TravelDocsController : ApiController
    {
        private DuringTravelAPIContext db = new DuringTravelAPIContext();

        // GET: api/TravelDocs
        public IQueryable<TravelDocs> GetTravelDocs()
        {
            return db.TravelDocs;
        }

        // GET: api/TravelDocs/5
        [ResponseType(typeof(TravelDocs))]
        public async Task<IHttpActionResult> GetTravelDocs(int id)
        {
            TravelDocs travelDocs = await db.TravelDocs.FindAsync(id);
            if (travelDocs == null)
            {
                return NotFound();
            }

            return Ok(travelDocs);
        }

        // PUT: api/TravelDocs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTravelDocs(int id, TravelDocs travelDocs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != travelDocs.TraveldocsId)
            {
                return BadRequest();
            }

            db.Entry(travelDocs).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelDocsExists(id))
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

        // POST: api/TravelDocs
        [ResponseType(typeof(TravelDocs))]
        public async Task<IHttpActionResult> PostTravelDocs(TravelDocs travelDocs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TravelDocs.Add(travelDocs);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = travelDocs.TraveldocsId }, travelDocs);
        }

        // DELETE: api/TravelDocs/5
        [ResponseType(typeof(TravelDocs))]
        public async Task<IHttpActionResult> DeleteTravelDocs(int id)
        {
            TravelDocs travelDocs = await db.TravelDocs.FindAsync(id);
            if (travelDocs == null)
            {
                return NotFound();
            }

            db.TravelDocs.Remove(travelDocs);
            await db.SaveChangesAsync();

            return Ok(travelDocs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TravelDocsExists(int id)
        {
            return db.TravelDocs.Count(e => e.TraveldocsId == id) > 0;
        }
    }
}