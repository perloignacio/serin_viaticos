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
    [RoutePrefix("ReservasHotel")]
    public class ReservasHotelController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(ReservasHotelMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [Route("Uno/{IdReservaHotel}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdReservaHotel)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (ReservasHotelMapper.Instance().GetOne(IdReservaHotel) == null)
                {
                    throw new Exception("No se encuentra el IdReservaHotel para la busqueda");
                }
                return Ok(ReservasHotelMapper.Instance().GetOne(IdReservaHotel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        
        

        [Route("AgregarEditar/{IdReservaHotel?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] ReservasHotel pf, int? IdReservaHotel = null)
        {
            try
            {
                ReservasHotelRules pfRules = new ReservasHotelRules();
                if (IdReservaHotel.HasValue)
                {
                    pfRules.Modificar(IdReservaHotel.Value, pf.IdDestino,pf.CantHabitaciones,pf.CantPasajeros, pf.IdHotel, pf.CodigoReserva, pf.Precio, pf.Checkin,pf.Checkout);
                }
                else
                {
                    pfRules.Agregar(pf.IdDestino, pf.CantHabitaciones, pf.CantPasajeros, pf.IdHotel, pf.CodigoReserva, pf.Precio, pf.Checkin, pf.Checkout);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        

        [Route("Borrar/{IdReservaHotel}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdReservaHotel)
        {
            try
            {
                ReservasHotelRules pf = new ReservasHotelRules();
                pf.Eliminar(IdReservaHotel);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

              
    }
}
