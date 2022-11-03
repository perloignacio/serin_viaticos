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
    [RoutePrefix("Hoteles")]
    public class HotelesController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(HotelesMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    

        [Route("Uno/{IdHotel}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdHotel)
        {
            try
            {
                return Ok(HotelesMapper.Instance().GetOne(IdHotel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

    
        [Route("AgregarEditar/{IdHotel?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Hoteles pf,int? IdHotel = null)
        {
            try
            {
                HotelesRules pfRules = new HotelesRules();
                if (IdHotel.HasValue)
                {
                    pfRules.Modificar(IdHotel.Value, pf.Nombre, pf.IdUbicacion, pf.Telefono, pf.Email, pf.Direccion);
                }
                else
                {
                    pfRules.Agregar(pf.Nombre, pf.IdUbicacion, pf.Telefono, pf.Email, pf.Direccion);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        
        

        [Route("Borrar/{IdHotel}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdHotel)
        {
            try
            {
                HotelesRules pf = new HotelesRules();
                pf.Eliminar(IdHotel);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    
     }
}
