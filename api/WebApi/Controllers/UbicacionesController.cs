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
                return Ok(UbicacionesMapper.Instance().GetAll().OrderBy(u=>u.Nombre));
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
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (UbicacionesMapper.Instance().GetOne(IdUbicacion) == null)
                {
                    throw new Exception("No se encuentra el IdUbicacion para la busqueda");
                }
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
                    pfRules.Modificar(IdUbicacion.Value, pf.Nombre,pf.Lat, pf.Lng);
                }
                else
                {
                    pfRules.Agregar(pf.Nombre,pf.Lat, pf.Lng); 
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
