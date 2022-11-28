using serin_viaticosRules;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("Solicitudes")]
    public class SolicitudesController : ApiController
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
                SolicitudesList lista = SolicitudesMapper.Instance().GetAll();
                foreach (var item in lista)
                {
                    
                    
                    usu.Fill(intra.Usuarios, item.IdUsuario);
                    if (intra.Usuarios.Rows.Count > 0)
                    {
                        dsIntranet.UsuariosRow r = (dsIntranet.UsuariosRow)intra.Usuarios.Rows[0];
                        Usuarios u = new Usuarios();
                        u.Nombre = r.Nombre;
                        u.Apellido = r.Apellido;
                        u.Email = r.Email;
                        u.IdUsuario = r.IdUsuario;
                        u.IdArea = Convert.ToInt32(r.IdArea);

                        item.Usuario = u;


                    }

                    item.Detalle = SolicitudesDetalleMapper.Instance().GetBySolicitudes(item.IdSolicitud);
                    item.SolcitudesUsuarios = SolicitudesUsuariosMapper.Instance().GetBySolicitudes(item.IdSolicitud);
                    foreach (var su in item.SolcitudesUsuarios)
                    {
                        usu.Fill(intra.Usuarios, su.IdUsuario);
                        if (intra.Usuarios.Rows.Count > 0)
                        {
                            dsIntranet.UsuariosRow r = (dsIntranet.UsuariosRow)intra.Usuarios.Rows[0];
                            Usuarios u = new Usuarios();
                            u.Nombre = r.Nombre;
                            u.Apellido = r.Apellido;
                            u.Email = r.Email;
                            u.IdUsuario = r.IdUsuario;
                            u.IdArea = Convert.ToInt32(r.IdArea);

                            su.UsuariosEntity = u;


                        }

                    }

                    foreach (var det in item.Detalle)
                    {
                        if (det.IdItinerario.HasValue)
                        {
                            det.ItinerarioEntity.Detalle = ItinerarioDetalleMapper.Instance().GetByItinerario(det.IdItinerario.Value);
                            
                        }
                    }
                }
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        
        [Route("Uno/{IdSolicitud}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Uno(int IdSolicitud)
        {
            try
            {
                //agregue esta validacion para que no tirara NUll cuando no encuentra el id
                if (SolicitudesMapper.Instance().GetOne(IdSolicitud) == null)
                {
                    throw new Exception("No se encuentra el IdSolicitud para la busqueda");
                }
                return Ok(SolicitudesMapper.Instance().GetOne(IdSolicitud));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [Route("AgregarEditar/{IdSolicitud?}")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Solicitudes pf, int? IdSolicitud = null)
        {
            try
            {
                SolicitudesRules pfRules = new SolicitudesRules();
                if (IdSolicitud.HasValue)
                {
                    pfRules.Modificar(IdSolicitud.Value, pf.Fecha, pf.IdUsuario, pf.IdSolicitudEstado, pf.EmailCopia, pf.Descripcion);
                }
                else
                {
                    pfRules.Agregar(pf.Fecha, pf.IdUsuario, pf.IdSolicitudEstado, pf.EmailCopia, pf.Descripcion,pf.SolcitudesUsuarios,pf.Detalle);
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }





        [Route("Borrar/{IdSolicitud}")]
        [HttpDelete]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int IdSolicitud)
        {
            try
            {
                SolicitudesRules pf = new SolicitudesRules();
                pf.Eliminar(IdSolicitud);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
