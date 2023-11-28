using APisuphero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APisuphero.Controllers
{
    public class AutentificacinController : ApiController
    {
        [HttpPost]
        [Route("api/Loguin")]
        public IHttpActionResult Index([FromBody] LoguinRequest login)
        {

            using (SuperHeroesEntities model = new SuperHeroesEntities())
            {

                try
                {
                    Superheromodels usuario = model.SuperHeroe.ToList()
                        .Where(x => (login.Username.ToLower() == x.Nombre )&&( x.contraseña.ToString() == login.Password.ToString()))
                        .Select(x => new Superheromodels(x)).FirstOrDefault();

                    if (usuario == default(Superheromodels))
                    {

                        return Content<LoguinRequest>(System.Net.HttpStatusCode.Unauthorized, null);
                    }

                    return Ok(new LoguinRespuesta
                    {
                        Token = GeneradorTokensController.generartoken(usuario.ID.ToString()),
                        DateTime = DateTime.Now,
                        User = usuario,
                        sucees = true
                        

                    });
                }
                catch (Exception e)
                {

                    return Content(System.Net.HttpStatusCode.BadRequest, e);
                }
            }

        }
    }
}
