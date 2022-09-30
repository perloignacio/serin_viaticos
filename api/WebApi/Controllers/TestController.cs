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

        /*
        [Route("agregar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Agregar([FromBody] Perfiles pf)
        {
            try
            {
                Perfiles pf = new PerfilesRules();
                /*if (IdPerfil != 0)
                {
                    tpv.Modificar(codigo, tp.codigo, tp.descripcion);
                }
                else
                {
                    pf.Agregar(pf.Nombre, pf.Nombre, pf.Activo , pf.RequiereAutorizacion, pf.Admin);
                //}

                return Ok(true);



            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        */

        

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
