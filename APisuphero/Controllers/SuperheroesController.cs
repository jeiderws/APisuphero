using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    public class SuperheroesController : ApiController
    {
        SuperHeroesEntities bd  = new SuperHeroesEntities();
        // GET: api/Superheroes
        public IHttpActionResult Get()
        {
            return Ok (bd.SuperHeroe.ToList().Select( x=> new Superheromodels(x)).ToList());
        }

        // GET: api/Superheroes/5
        public IHttpActionResult Get(int id)
        {
            return Ok(bd.SuperHeroe.ToList().Where( a=> a.ID == id).Select(x => new Superheromodels(x)).ToList());
        }

        // POST: api/Superheroes
        public IHttpActionResult Post([FromBody]SuperHeroe sp)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);

                }
                bd.SuperHeroe.Add(sp);
                bd.SaveChanges();
                return CreatedAtRoute("Defaultapi", new { id = sp.ID }, sp);
            }
            catch (Exception ex)
            {

                return Content(System.Net.HttpStatusCode.BadRequest, ex);
            }
           
        }

        // PUT: api/Superheroes/5
        public IHttpActionResult Put( [FromBody]SuperHeroe sp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bd.Entry(sp).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
            return Ok(sp);
        }

        // DELETE: api/Superheroes/5
        public IHttpActionResult Delete(int id)
        {
            var superhe = bd.SuperHeroe.FirstOrDefault(x => x.ID == id);
            bd.SuperHeroe.Remove(superhe);
            bd.SaveChanges();
            return Ok(superhe);
        }
    }
}
