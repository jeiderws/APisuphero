using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    public class TipoMionesController : ApiController
    {

        SuperHeroesEntities bd = new SuperHeroesEntities();
        // GET: api/TipoMiones
        public IHttpActionResult Get()
        {
            return Ok(bd.TipoMision.ToList().Select(x => new TipoMisionmodels(x)).ToList());
        }

        // GET: api/TipoMiones/5
        public IHttpActionResult Get(int id)
        {
            return Ok(bd.TipoMision.ToList().Where(a => a.ID == id).Select(x => new TipoMisionmodels(x)).ToList());
        }

        // POST: api/TipoMiones
        public IHttpActionResult Post([FromBody]TipoMision tp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            bd.TipoMision.Add(tp);
            bd.SaveChanges();
            return CreatedAtRoute("Defaultapi", new { id = tp.ID },tp);
        }

        // PUT: api/TipoMiones/5
        public IHttpActionResult Put([FromBody] TipoMision tp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);    
            }
            bd.Entry(tp).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
            return Ok(tp);
        }

        // DELETE: api/TipoMiones/5
        public IHttpActionResult Delete(int id)
        {
            var tipm = bd.TipoMision.FirstOrDefault(x => x.ID == id);
            bd.TipoMision.Remove(tipm);
            bd.SaveChanges();
            return Ok(tipm);
        }
    }
}
