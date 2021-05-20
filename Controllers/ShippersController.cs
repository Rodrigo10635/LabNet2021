using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Aplicacion_webApi.Models;

namespace Aplicacion_webApi.Controllers
{
    public class ShippersController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Shippers
        public IQueryable<Shippers> GetShippers()
        {
            return db.Shippers;
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Shippers/5
        [ResponseType(typeof(Shippers))]
        public IHttpActionResult GetShippers(int id)
        {
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return NotFound();
            }

            return Ok(shippers);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // PUT: api/Shippers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutShippers(int id, Shippers shippers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shippers.ShipperID)
            {
                return BadRequest();
            }

            db.Entry(shippers).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShippersExists(id))
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
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // POST: api/Shippers
        [ResponseType(typeof(Shippers))]
        public IHttpActionResult PostShippers(Shippers shippers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Shippers.Add(shippers);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = shippers.ShipperID }, shippers);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // DELETE: api/Shippers/5
        [ResponseType(typeof(Shippers))]
        public IHttpActionResult DeleteShippers(int id)
        {
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return NotFound();
            }

            db.Shippers.Remove(shippers);
            db.SaveChanges();

            return Ok(shippers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShippersExists(int id)
        {
            return db.Shippers.Count(e => e.ShipperID == id) > 0;
        }
    }
}