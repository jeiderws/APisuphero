using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    public class GrupoController : ApiController
    {

        SuperHeroesEntities bd = new SuperHeroesEntities();
        // GET: api/Grupo
        public IHttpActionResult Get()
        {
            return Ok(bd.Grupo.ToList().Select(x => new GrupoModels(x)).ToList());
        }

        // GET: api/Grupo/5
        public IHttpActionResult Get(int id)
        {
            return Ok(bd.Grupo.ToList().Where(a => a.ID == id).Select(x => new GrupoModels(x)).ToList());
        }

        // POST: api/Grupo
        public IHttpActionResult Post([FromBody]Grupo gp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            bd.Grupo.Add(gp);
            bd.SaveChanges();
            return CreatedAtRoute("Defaultapi", new { id = gp.ID }, gp);
        }

        // PUT: api/Grupo/5
        public IHttpActionResult Put( [FromBody]Grupo gp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            bd.Entry(gp).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
            return Ok(gp);
        }

        // DELETE: api/Grupo/5
        public IHttpActionResult Delete(int id)
        {
            var grupo = bd.Grupo.FirstOrDefault(x => x.ID == id);
            bd.Grupo.Remove(grupo);
            bd.SaveChanges();
            return Ok(grupo);
        }
    }
}
