using Api.Clases;
using serin_intranetRules;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{

        [RoutePrefix("usuarios")]
    public class UsuariosController : ApiController
    {



        [Route("login")]
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult Login(string usuario, string contra)
        {
            try
            {
                dsIntranet intra = new dsIntranet();
                dsIntranetTableAdapters.UsuariosTableAdapter usu = new dsIntranetTableAdapters.UsuariosTableAdapter();
                usu.Login(intra.Usuarios, usuario, Utils.Encrypt(contra));
                if (intra.Usuarios.Rows.Count > 0)
                {
                    dsIntranet.UsuariosRow r = (dsIntranet.UsuariosRow)intra.Usuarios.Rows[0];
                    Usuarios u = new Usuarios();
                    u.Nombre = r.Nombre;
                    u.Apellido = r.Apellido;
                    u.Email = r.Email;
                    u.IdUsuario = r.IdUsuario;
                    u.IdArea = Convert.ToInt32(r.IdArea);
                    u.Token = TokenGenerator.GenerateTokenJwt(r.IdUsuario.ToString());
                    return Ok(u);

                }
                else
                {
                    return BadRequest("No se encuentra el usuario");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }
    }
}
