using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAplicacion.Controllers
{
    public class PersonaController : ApiController
    {
        [HttpPost]
        public IHttpActionResult add()
        {
            using (Models.PruebaEntities db =new Models.PruebaEntities())
            {
                var oPersona = new Models.Persona();
                oPersona.nombre = "Jorge";
                oPersona.edad = 12;
                //Para hace el insert
                db.Persona.Add(oPersona);
                //Pero aun no manda nada, para mandar algo hay que ahcer los uiguiente
                db.SaveChanges();
            }
            return Ok("Exito");
        }
    }
}
