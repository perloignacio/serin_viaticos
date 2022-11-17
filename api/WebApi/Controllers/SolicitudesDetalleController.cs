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
    [RoutePrefix("SolicitudesDetalle")]
    public class SolicitudesDetalleController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(SolicitudesDetalleMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        [Route("Uno/{IdSolicitudDetalle}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdSolicitudDetalle)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (SolicitudesDetalleMapper.Instance().GetOne(IdSolicitudDetalle) == null)
                {
                    throw new Exception("No se encuentra el IdSolicitudDetalle para la busqueda");
                }
                return Ok(SolicitudesDetalleMapper.Instance().GetOne(IdSolicitudDetalle));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        

        [Route("AgregarEditar/{IdSolicitudDetalle?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] SolicitudesDetalle pf, int? IdSolicitudDetalle = null)
        {
            try
            {
                SolicitudesDetalleRules pfRules = new SolicitudesDetalleRules();
                if (IdSolicitudDetalle.HasValue)
                {
                    pfRules.Modificar(IdSolicitudDetalle.Value, pf.IdSolicitud, pf.IdSolicitudCategoria, pf.IdReservaAereo, pf.IdResevaHotel, pf.IdItinerario, pf.IdReservaAlquilerAuto, pf.Observaciones);
                }
                else
                {
                    pfRules.Agregar(pf.IdSolicitud, pf.IdSolicitudCategoria, pf.IdReservaAereo, pf.IdResevaHotel, pf.IdItinerario, pf.IdReservaAlquilerAuto, pf.Observaciones);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        


        [Route("Borrar/{IdSolicitudDetalle}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdSolicitudDetalle)
        {
            try
            {
                SolicitudesDetalleRules pf = new SolicitudesDetalleRules();
                pf.Eliminar(IdSolicitudDetalle);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    
    }
}
