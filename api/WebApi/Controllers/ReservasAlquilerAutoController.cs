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
    [RoutePrefix("ReservasAlquilerAuto")]
    public class ReservasAlquilerAutoController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(ReservasAlquilerAutoMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [Route("Uno/{IdReservaAlquilerAuto}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdReservaAlquilerAuto)
        {
            try
            {
                return Ok(ReservasAlquilerAutoMapper.Instance().GetOne(IdReservaAlquilerAuto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        
        [Route("AgregarEditar/{IdReservaAlquilerAuto?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] ReservasAlquilerAuto pf, int? IdReservaAlquilerAuto  = null)
        {
            try
            {
                ReservasAlquilerAutoRules pfRules = new ReservasAlquilerAutoRules();
                if (IdReservaAlquilerAuto.HasValue)
                {
                    pfRules.Modificar(IdReservaAlquilerAuto.Value, pf.IdDestino, pf.CantPasajeros, pf.Marca, pf.Modelo, pf.FechaDesde,pf.FechaHasta, (decimal)pf.Precio);
                }
                else
                {
                    pfRules.Agregar(pf.IdDestino, pf.CantPasajeros, pf.Marca, pf.Modelo, pf.FechaDesde, pf.FechaHasta, (decimal)pf.Precio);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Borrar/{IdReservaAlquilerAuto}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdReservaAlquilerAuto)
        {
            try
            {
                ReservasAlquilerAutoRules pf = new ReservasAlquilerAutoRules();
                pf.Eliminar(IdReservaAlquilerAuto);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

                
    }
}
