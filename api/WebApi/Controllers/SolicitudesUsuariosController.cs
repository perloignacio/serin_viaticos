using serin_viaticosRules;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("SolicitudesUsuarios")]
    public class SolicitudesUsuariosController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(SolicitudesUsuariosMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        [Route("Uno/{IdSolicitudUsuario}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdSolicitudUsuario)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (SolicitudesUsuariosMapper.Instance().GetOne(IdSolicitudUsuario) == null)
                {
                    throw new Exception("No se encuentra el IdSolicitudUsuario para la busqueda");
                }
                return Ok(SolicitudesUsuariosMapper.Instance().GetOne(IdSolicitudUsuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        
        [Route("AgregarEditar/{IdSolicitudUsuario?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] SolicitudesUsuarios pf, int? IdSolicitudUsuario = null)
        {
            try
            {
                 SolicitudesUsuariosRules pfRules = new SolicitudesUsuariosRules();
                if (IdSolicitudUsuario.HasValue)
                {
                    pfRules.Modificar(IdSolicitudUsuario.Value, pf.IdSolicitud, pf.IdUsuario, pf.MontoAnticipo);
                }
                else
                {
                    pfRules.Agregar(pf.IdSolicitud, pf.IdUsuario, pf.MontoAnticipo);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        


        [Route("Borrar/{IdSolicitudUsuario}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdSolicitudUsuario)
        {
            try
            {
                SolicitudesUsuariosRules pf = new SolicitudesUsuariosRules();
                pf.Eliminar(IdSolicitudUsuario);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
       
        
    }
}
