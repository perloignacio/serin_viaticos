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
    [RoutePrefix("perfiles")]
    public class PerfilesController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(PerfilesMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Activos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Activos()
        {
            try
            {
                return Ok(PerfilesMapper.Instance().GetAll().Where(p=>p.Activo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Uno/{IdPerfil}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdPerfil)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (PerfilesMapper.Instance().GetOne(IdPerfil) == null)
                {
                    throw new Exception("No se encuentra el IdPerfil para la busqueda");
                }

                return Ok(PerfilesMapper.Instance().GetOne(IdPerfil));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [Route("Activar/{IdPerfil}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Activar(int IdPerfil)
        {
            try
            {
                PerfilesRules pfRules = new PerfilesRules();
                pfRules.Activar(IdPerfil);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [Route("AgregarEditar/{IdPerfil?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Perfiles pf,int? IdPerfil=null)
        {
            try
            {
                PerfilesRules pfRules = new PerfilesRules();
                if (IdPerfil.HasValue)
                {
                    pfRules.Modificar(IdPerfil.Value, pf.Nombre,  pf.RequiereAutorizacion, pf.Admin);
                }
                else
                {
                    pfRules.Agregar(pf.Nombre, pf.RequiereAutorizacion, pf.Admin);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        


        [Route("Borrar/{IdPerfil}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdPerfil)
        {
            try
            {
                PerfilesRules pf = new PerfilesRules();
                pf.Eliminar(IdPerfil);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
