using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    public class PoderController : ApiController
    {

        SuperHeroesEntities bd = new SuperHeroesEntities();
        // GET: api/Poder
        public IHttpActionResult Get()
        {
            return Ok( bd.Poder.ToList().Select(x => new PoderModels(x)).ToList());
        }

        // GET: api/Poder/5
        public IHttpActionResult Get(int id)
        {
            return Ok(bd.Poder.ToList().Where( a => a.ID == id).Select(x => new PoderModels(x)).ToList());
        }

        // POST: api/Poder
        public IHttpActionResult Post([FromBody]Poder pd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            bd.Poder.Add(pd);
            bd.SaveChanges();
            return CreatedAtRoute("Defaultapi", new { id = pd.ID }, pd);

        }

        // PUT: api/Poder/5
        public IHttpActionResult Put( [FromBody]Poder pd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bd.Entry(pd).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
            return Ok(pd);
        }

        // DELETE: api/Poder/5
        public IHttpActionResult Delete(int id)
        {
            var poder = bd.Poder.FirstOrDefault(x => x.ID == id);
            bd.Poder.Remove(poder);
            bd.SaveChanges();
            return Ok(poder);
        }
    }
}
