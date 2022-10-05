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
    [RoutePrefix("categorias")]
    public class CategoriasController : ApiController
    {
        [Route("GetTodos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetTodos()
        {
            try
            {
                return Ok(CategoriasGastoMapper.Instance().GetAll());
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
                return Ok(CategoriasGastoMapper.Instance().GetAll().Where(p => p.Activo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Uno/{IdCategoria}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdCategoria)
        {
            try
            {
                return Ok(CategoriasGastoMapper.Instance().GetOne(IdCategoria));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [Route("Activar/{IdCategoria}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Activar(int IdCategoria)
        {
            try
            {
                CategoriasRules cRules = new CategoriasRules();
                cRules.Activar(IdCategoria);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [Route("AgregarEditar/{IdCategoria?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] CategoriasGasto cg, int? IdCategoria = null)
        {
            try
            {
                CategoriasRules cRules = new CategoriasRules();
                if (IdCategoria.HasValue)
                {
                    cRules.Modificar(IdCategoria.Value,cg.Nombre,cg.EmailNotificacion);
                }
                else
                {
                    cRules.Agregar(cg.Nombre, cg.EmailNotificacion);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }





        [Route("Borrar/{IdCategoria}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdCategoria)
        {
            try
            {
                CategoriasRules cRules = new CategoriasRules();
                cRules.Eliminar(IdCategoria);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
