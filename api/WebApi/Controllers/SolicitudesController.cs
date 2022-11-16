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
    [RoutePrefix("Solicitudes")]
    public class SolicitudesController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(SolicitudesMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        [Route("Uno/{IdSolicitud}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdSolicitud)
        {
            try
            {
                return Ok(SolicitudesMapper.Instance().GetOne(IdSolicitud));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        
        [Route("AgregarEditar/{IdSolicitud?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Solicitudes pf, int? IdSolicitud = null)
        {
            try
            {
                SolicitudesRules pfRules = new SolicitudesRules();
                if (IdSolicitud.HasValue)
                {
                    pfRules.Modificar(IdSolicitud.Value, pf.Fecha, pf.IdUsuario, pf.IdSolicitudEstado, pf.EmailCopia, pf.Descripcion);
                }
                else
                {
                    pfRules.Agregar(pf.Fecha, pf.IdUsuario, pf.IdSolicitudEstado, pf.EmailCopia, pf.Descripcion);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        


        [Route("Borrar/{IdSolicitud}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdSolicitud)
        {
            try
            {
                SolicitudesRules pf = new SolicitudesRules();
                pf.Eliminar(IdSolicitud);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
