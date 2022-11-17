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
    [RoutePrefix("SolicitudesEstados")]
    public class SolicitudesEstadosController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(SolicitudesEstadosMapper.Instance().GetAll());
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
                
                return Ok(SolicitudesEstadosMapper.Instance().GetAll().Where(p=>p.Activo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Uno/{IdSolicitudEstado}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdSolicitudEstado)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (SolicitudesEstadosMapper.Instance().GetOne(IdSolicitudEstado) == null)
                {
                    throw new Exception("No se encuentra el IdSolicitudEstado para la busqueda");
                }
                return Ok(SolicitudesEstadosMapper.Instance().GetOne(IdSolicitudEstado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [Route("Activar/{IdSolicitudEstado}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Activar(int IdSolicitudEstado)
        {
            try
            {
                SolicitudesEstadoRules pfRules = new SolicitudesEstadoRules();
                pfRules.Activar(IdSolicitudEstado);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [Route("AgregarEditar/{IdSolicitudEstado?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] SolicitudesEstados pf, int? IdSolicitudEstado = null)
        {
            try
            {
                SolicitudesEstadoRules pfRules = new SolicitudesEstadoRules();
                if (IdSolicitudEstado.HasValue)
                {
                    pfRules.Modificar(IdSolicitudEstado.Value, pf.Nombre,pf.Activo);
                }
                else
                {
                    pfRules.Agregar(pf.IdSolicitudEstado, pf.Nombre,  pf.Activo);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




        [Route("Borrar/{IdSolicitudEstado}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar (int IdSolicitudEstado)
        {
            try
            {
                SolicitudesEstadoRules pf = new SolicitudesEstadoRules();
                
                pf.Eliminar(IdSolicitudEstado);
                return Ok(true);
            }
            catch (Exception ex)
            {   
                return BadRequest(ex.Message);
            }

        }



    }
}
