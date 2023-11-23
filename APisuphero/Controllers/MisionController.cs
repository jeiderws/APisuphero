using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    [Authorize]
    public class MisionController : ApiController
    {
        SuperHeroesEntities bd = new SuperHeroesEntities();
        // GET: api/Mision
        public IHttpActionResult Get()
        {
            return Ok(bd.Misiones.ToList().Select(x => new Misionesmodels(x)).ToList());
        }

        // GET: api/Mision/5
        public IHttpActionResult Get(int id)
        {
            return Ok(bd.Misiones.ToList().Where( a => a.ID == id).Select(x => new Misionesmodels(x)).ToList());
        }

        // POST: api/Mision
        public IHttpActionResult Post([FromBody]Misiones ms)
        {
            if (!ModelState.IsValid)
            {
                 return BadRequest(ModelState);
            }
            bd.Misiones.Add(ms);
            bd.SaveChanges();
            return CreatedAtRoute("dij", new {id  = ms.ID},ms);
        }

        // PUT: api/Mision/5
        public IHttpActionResult Put( [FromBody]Misiones ms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bd.Entry(ms).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
            return Ok(ms);
        }

        // DELETE: api/Mision/5
        public IHttpActionResult Delete(int id)
        {
            var mision = bd.Misiones.FirstOrDefault( x => x.ID == id);
            bd.Misiones.Remove(mision);
            bd.SaveChanges();
            return Ok(mision);
        }
    }
}
