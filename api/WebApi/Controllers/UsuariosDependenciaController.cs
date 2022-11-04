using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using serin_viaticosRules;
using WebApi.Models;

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
                dsIntranet intra = new dsIntranet();
                serin_viaticosRules.dsIntranetTableAdapters.UsuariosTableAdapter usu = new serin_viaticosRules.dsIntranetTableAdapters.UsuariosTableAdapter();
                List<UsuariosDependencia> UDPList = new List<UsuariosDependencia>();
                foreach (var item in UsuariosDependenciaMapper.Instance().GetAll())
                {
                    usu.Fill(intra.Usuarios,item.IdUsuarioHijo);
                    if (intra.Usuarios.Rows.Count > 0)
                    {
                        dsIntranet.UsuariosRow r = (dsIntranet.UsuariosRow)intra.Usuarios.Rows[0];
                        Usuarios u = new Usuarios();
                        u.Nombre = r.Nombre;
                        u.Apellido = r.Apellido;
                        u.Email = r.Email;
                        u.IdUsuario = r.IdUsuario;
                        item.UsuarioHijo = u;
                        item.ApellidoHijo = r.Apellido;
                    }

                    usu.Fill(intra.Usuarios, item.IdUsuarioPadre);
                    if (intra.Usuarios.Rows.Count > 0)
                    {
                        dsIntranet.UsuariosRow r = (dsIntranet.UsuariosRow)intra.Usuarios.Rows[0];
                        Usuarios u = new Usuarios();
                        u.Nombre = r.Nombre;
                        u.Apellido = r.Apellido;
                        u.Email = r.Email;
                        u.IdUsuario = r.IdUsuario;
                        item.UsuarioPadre = u;
                    }

                    UDPList.Add(item);

                }
                return Ok(UDPList.OrderBy(u=>u.ApellidoHijo));
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
