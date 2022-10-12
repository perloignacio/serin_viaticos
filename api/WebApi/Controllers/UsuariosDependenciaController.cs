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
    [RoutePrefix("UsuariosDependencia")]
    public class UsuariosDependenciaController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(UsuariosDependenciaMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Uno/{IdUsuarioPadre}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdUsuarioPadre)
        {
            try
            {
                return Ok(UsuariosDependenciaMapper.Instance().GetOne(IdUsuarioPadre));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        
        [Route("AgregarEditar/{IdDependenciaUsuario?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] UsuariosDependencia ud, int? IdDependenciaUsuario = null)
        {
            try
            {
                UsuariosDependenciaRules cRules = new UsuariosDependenciaRules();
                if (IdDependenciaUsuario.HasValue)
                {
                    cRules.Modificar(IdDependenciaUsuario.Value,ud.IdUsuarioPadre, ud.IdUsuarioHijo);
                }
                else
                {
                    cRules.Agregar(ud.IdUsuarioPadre, ud.IdUsuarioHijo);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


      

        [Route("Borrar/{IdDependenciaUsuario}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdDependenciaUsuario)
        {
            try
            {
                UsuariosDependenciaRules pu = new UsuariosDependenciaRules();
                pu.Eliminar(IdDependenciaUsuario);
                              
                
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
