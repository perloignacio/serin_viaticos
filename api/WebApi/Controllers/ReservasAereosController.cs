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
    [RoutePrefix("ReservasAereos")]
    public class ReservasAereosController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(ReservasAereosMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [Route("Uno/{IdReservaAereo}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdReservaAereo)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (ReservasAereosMapper.Instance().GetOne(IdReservaAereo) == null)
                {
                    throw new Exception("No se encuentra el IdReservaAereo para la busqueda");
                }
                return Ok(ReservasAereosMapper.Instance().GetOne(IdReservaAereo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        
        [Route("AgregarEditar/{IdReservaAereo?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] ReservasAereos pf, int? IdReservaAereo = null)
        {
            try
            {
                ReservasAereosRules pfRules = new ReservasAereosRules();
                if (IdReservaAereo.HasValue)
                {
                    pfRules.Modificar(IdReservaAereo.Value, pf.IdOrigen,  pf.IdDestino, pf.CantPasajeros, pf.FechaViaje, pf.IdaVuelta, pf.Precio);
                }
                else
                {
                    pfRules.Agregar(pf.IdReservaAereo, pf.IdOrigen, pf.IdDestino, pf.CantPasajeros, pf.FechaViaje, pf.IdaVuelta,pf.Precio);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Borrar/{IdReservaAereo}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdReservaAereo)
        {
            try
            {
                ReservasAereosRules pf = new ReservasAereosRules();
                pf.Eliminar(IdReservaAereo);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
