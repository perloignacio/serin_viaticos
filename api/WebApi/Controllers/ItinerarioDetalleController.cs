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
    [RoutePrefix("ItinerarioDetalle")]
    public class ItinerarioDetalleController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(ItinerarioDetalleMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        [Route("Uno/{IdItinerarioDetalle}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdItinerarioDetalle)
        {
            try
            {
                return Ok(ItinerarioMapper.Instance().GetOne(IdItinerarioDetalle));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [Route("AgregarEditar/{IdItinerarioDetalle?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] ItinerarioDetalle pf, int? IdItinerarioDetalle  = null)
        {
            try
            {
                ItinerarioDetalleRules pfRules = new ItinerarioDetalleRules();
                if (IdItinerarioDetalle.HasValue)
                {
                    pfRules.Modificar(IdItinerarioDetalle.Value, pf.IdItinerario, pf.IdOrigen, pf.IdDestino);
                }
                else
                {
                    pfRules.Agregar(pf.IdItinerario, pf.IdOrigen, pf.IdDestino);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        
        [Route("Borrar/{IdItinerarioDetalle}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdItinerarioDetalle)
        {
            try
            {
                ItinerarioDetalleRules pf = new ItinerarioDetalleRules();
                pf.Eliminar(IdItinerarioDetalle);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
                
            
    }
}
