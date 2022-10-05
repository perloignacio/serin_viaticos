using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using serin_viaticosRules;
namespace WebApi.Controllers
{
    [RoutePrefix("test")]
    public class TestController : ApiController
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

        [Route("Uno")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdPerfil)
        {
            try
            {
                return Ok(PerfilesMapper.Instance().GetOne(IdPerfil));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
         

        }


        [Route("agregar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Agregar([FromBody] Perfiles pf)
        {
            try
            {
                //int IdPerfil = 0;
                PerfilesRules pfRules = new PerfilesRules();
                if (pf.IdPerfil != 0)
                {
                    pfRules.Modificar(pf.IdPerfil, pf.Nombre, pf.Activo, pf.RequiereAutorizacion, pf.Admin);
                }
                else
                {
                    pfRules.Agregar(pf.Nombre, pf.Activo, pf.RequiereAutorizacion, pf.Admin);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("modificar")]
        [HttpPut]
        [AllowAnonymous]
        public IHttpActionResult Modificar([FromBody] Perfiles pf)
        {
            try
            {
                PerfilesRules pfRules = new PerfilesRules();
                pfRules.Modificar(pf.IdPerfil, pf.Nombre, pf.Activo, pf.RequiereAutorizacion, pf.Admin);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Borrar")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdPerfil)
        {
            try
            {
                PerfilesRules pf = new serin_viaticosRules.PerfilesRules();
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
