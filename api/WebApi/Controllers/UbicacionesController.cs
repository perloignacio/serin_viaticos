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
    [RoutePrefix("Ubicaciones")]
    public class UbicacionesController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(UbicacionesMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Uno/{IdUbicacion}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdUbicacion)
        {
            try
            {
                return Ok(UbicacionesMapper.Instance().GetOne(IdUbicacion));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        
        [Route("AgregarEditar/{IdUbicacion?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Ubicaciones pf,int? IdUbicacion = null)
        {
            try
            {
                UbicacionesRules pfRules = new UbicacionesRules();
                if (IdUbicacion.HasValue)
                {
                    pfRules.Modificar(IdUbicacion.Value, pf.Nombre, (long)pf.Lat, (long)pf.Lng);
                }
                else
                {
                    pfRules.Agregar(pf.Nombre, (long)pf.Lat, (long)pf.Lng); 
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


   


        [Route("Borrar/{IdUbicacion}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdUbicacion)
        {
            try
            {
                UbicacionesRules pf = new UbicacionesRules();
                pf.Eliminar(IdUbicacion);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
