using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    public class RegistroController : ApiController
    {
        [HttpPost]
        [Route("Registro")]
        public IHttpActionResult Registrarsu([FromBody]SuperHeroe reg)
        {
            using (SuperHeroesEntities bd = new SuperHeroesEntities()) 
            {
                try
                {
                    //Registrosuperhero registr = bd.SuperHeroe.ToList()
                    //    .Where(x => x.Nombre == reg.Nombre);
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);

                    }
                    bd.SuperHeroe.Add(reg);
                    bd.SaveChanges();
                    return CreatedAtRoute("Defaultapi", new { id = reg.ID }, reg);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

    }
}
