using Api.Clases;
using serin_intranetRules;
using serin_viaticosRules;
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
                serin_viaticosRules.dsIntranetTableAdapters.UsuariosTableAdapter usu = new serin_viaticosRules.dsIntranetTableAdapters.UsuariosTableAdapter();
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


        [Route("todos")]
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult todos()
        {
            string idusuario = "";
            try
            {
                dsIntranet intra = new dsIntranet();
                serin_viaticosRules.dsIntranetTableAdapters.UsuariosTableAdapter usu = new serin_viaticosRules.dsIntranetTableAdapters.UsuariosTableAdapter();
                usu.Fillall(intra.Usuarios);
                List<Usuarios> usuarios = new List<Usuarios>();
                foreach (var r in intra.Usuarios)
                {
                    idusuario = r.IdUsuario.ToString();
                    Usuarios u = new Usuarios();
                    u.Nombre = r.Nombre;
                    u.Apellido = r.Apellido;
                    u.Email = r.Email;
                    u.IdUsuario = r.IdUsuario;
                    u.IdArea = 0;
                    u.Token = "";
                    usuarios.Add(u);

                }
                return Ok(usuarios.OrderBy(u=>u.Apellido));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message+"-"+idusuario);
            }



        }
    }
}
