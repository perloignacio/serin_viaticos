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
    [RoutePrefix("PerfilesUsuarios")]
    public class PerfilesUsuariosController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(PerfilesUsuariosMapper.Instance().GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Uno/{IdUsuario}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdUsuario)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (PerfilesUsuariosMapper.Instance().GetOne(IdUsuario) == null)
                {
                    throw new Exception("No se encuentra el IdUsuarioPerfil para la busqueda");
                }
                return Ok(PerfilesUsuariosMapper.Instance().GetOne(IdUsuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [Route("AgregarEditar/{IdUsuarioPerfil?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] PerfilesUsuarios pu, int? IdUsuarioPerfil = null)
        {
            try
            {
                PerfilesUsuariosRules cRules = new PerfilesUsuariosRules();
                if (IdUsuarioPerfil.HasValue)
                {
                    cRules.Modificar(IdUsuarioPerfil.Value,pu.IdUsuario, pu.IdPerfil);
                }
                else
                {
                    cRules.Agregar(pu.IdUsuario, pu.IdPerfil);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("Borrar/{IdUsuarioPerfil}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdUsuarioPerfil)
        {
            try
            {
                // elimina por IdUsuarioPerfil me parece podria eliminar por IdUsuario
                PerfilesUsuariosRules pu = new PerfilesUsuariosRules();
                pu.Eliminar(IdUsuarioPerfil);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
    }
}
