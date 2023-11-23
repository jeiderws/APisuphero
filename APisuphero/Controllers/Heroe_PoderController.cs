﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APisuphero.Models;

namespace APisuphero.Controllers
{
    [Authorize]
    public class Heroe_PoderController : ApiController
    {
        private SuperHeroesEntities db = new SuperHeroesEntities();

        // GET: api/Heroe_Poder
        public IHttpActionResult GetHeroe_Poder()
        {
            return Ok(db.Heroe_Poder.FirstOrDefault());
        }

        // GET: api/Heroe_Poder/5
        //[ResponseType(typeof(Heroe_Poder))]
        //public IHttpActionResult GetHeroe_Poder(int id)
        //{
        //    Heroe_Poder heroe_Poder = db.Heroe_Poder.Find(id);
        //    if (heroe_Poder == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(heroe_Poder);
        //}

        // PUT: api/Heroe_Poder/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHeroe_Poder( Heroe_Poder hp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Entry(hp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok(hp);
        }

        // POST: api/Heroe_Poder
        [ResponseType(typeof(Heroe_Poder))]
        public IHttpActionResult PostHeroe_Poder(Heroe_Poder hp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            db.Heroe_Poder.Add(hp);
            db.SaveChanges();
            return CreatedAtRoute("Defaultapi", new { id = hp.IDPoder, id2 = hp.IDHeroe}, hp);
        }

        // DELETE: api/Heroe_Poder/5
        [ResponseType(typeof(Heroe_Poder))]
        public IHttpActionResult DeleteHeroe_Poder(int id , int id2)
        {
            var hepo = db.Heroe_Poder.FirstOrDefault(x => x.IDHeroe == id && x.IDPoder == id2);
            db.Heroe_Poder.Remove(hepo);
            db.SaveChanges();
            return Ok(hepo);
        }

 
    }
}