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
    [RoutePrefix("Itinerario")]
    public class ItinerarioController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(ItinerarioMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // MUESTRA LOS ITINERARIOS CON IDA Y VUELTA
        [Route("Activos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Activos()
        {
            try
            {
                return Ok(ItinerarioMapper.Instance().GetAll().Where(p=>p.IdaVuelta));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        

        [Route("Uno/{IdItinerario}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdItinerario)
        {
            try
            {
                return Ok(ItinerarioMapper.Instance().GetOne(IdItinerario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("AgregarEditar/{IdItinerario?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Itinerario pf, int? IdItinerario = null)
        {
            try
            {
                ItinerarioRules pfRules = new ItinerarioRules();
                if (IdItinerario.HasValue)
                {
                    pfRules.Modificar(IdItinerario.Value, pf.Fecha, pf.IdaVuelta);
                }
                else
                {
                    pfRules.Agregar(pf.Fecha, pf.IdaVuelta);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Borrar/{IdItinerario}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdItinerario)
        {
            try
            {
                ItinerarioRules pf = new ItinerarioRules();
                pf.Eliminar(IdItinerario);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
    }
}
