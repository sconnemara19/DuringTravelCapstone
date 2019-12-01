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
    public class TravelDocsController : ApiController
    {
        private DuringTravelApiContext db = new DuringTravelApiContext();

        // GET: api/TravelDocs
        public IQueryable<TravelDocs> GetTravelDocs()
        {
            return db.TravelDocs;
        }

        // GET: api/TravelDocs/5
        [ResponseType(typeof(TravelDocs))]
        public IHttpActionResult GetTravelDocs(int id)
        {
            TravelDocs travelDocs = db.TravelDocs.Find(id);
            if (travelDocs == null)
            {
                return NotFound();
            }

            return Ok(travelDocs);
        }

        // PUT: api/TravelDocs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTravelDocs(int id, TravelDocs travelDocs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != travelDocs.travelDocId)
            {
                return BadRequest();
            }

            db.Entry(travelDocs).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
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
        public IHttpActionResult PostTravelDocs(TravelDocs travelDocs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TravelDocs.Add(travelDocs);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = travelDocs.travelDocId }, travelDocs);
        }

        // DELETE: api/TravelDocs/5
        [ResponseType(typeof(TravelDocs))]
        public IHttpActionResult DeleteTravelDocs(int id)
        {
            TravelDocs travelDocs = db.TravelDocs.Find(id);
            if (travelDocs == null)
            {
                return NotFound();
            }

            db.TravelDocs.Remove(travelDocs);
            db.SaveChanges();

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
            return db.TravelDocs.Count(e => e.travelDocId == id) > 0;
        }
    }
}