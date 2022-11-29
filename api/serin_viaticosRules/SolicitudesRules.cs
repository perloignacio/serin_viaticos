using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class SolicitudesRules
    {
        public void Agregar(DateTime Fecha, int IdUsuario, int IdSolicituEstado,string EmailCopia, string Descripcion,List<SolicitudesUsuarios> usuarios,List<SolicitudesDetalle> detalle)
        {
            Validar(Fecha, IdUsuario);
            Solicitudes pf = new Solicitudes();
                 
            pf.Fecha = Fecha;
            pf.IdUsuario = IdUsuario;
            pf.IdSolicitudEstado = 1;
            pf.EmailCopia = EmailCopia;
            pf.Descripcion = Descripcion;
            pf.IdSolicitudEstado = 1;
            SolicitudesMapper.Instance().Insert(pf);

            foreach (var su in usuarios)
            {
                su.IdSolicitud = pf.IdSolicitud;
                SolicitudesUsuariosMapper.Instance().Insert(su);
            }

            foreach (var det in detalle)
            {
                if (det.ItinerarioEntity != null)
                {
                    ItinerarioRules ir = new ItinerarioRules();
                    det.IdItinerario = ir.Agregar(det.ItinerarioEntity.Fecha, det.ItinerarioEntity.IdaVuelta, det.ItinerarioEntity.FechaVuelta, det.ItinerarioEntity.Km, det.ItinerarioEntity.Detalle);
                    
                }

                if (det.ReservasAereosEntity != null)
                {
                    ReservasAereosRules rr = new ReservasAereosRules();
                    det.IdReservaAereo=rr.Agregar(det.ReservasAereosEntity.IdOrigen,det.ReservasAereosEntity.IdDestino,det.ReservasAereosEntity.CantPasajeros,det.ReservasAereosEntity.FechaViaje,det.ReservasAereosEntity.IdaVuelta,det.ReservasAereosEntity.Precio,det.ReservasAereosEntity.FechaRegreso);

                }

                if (det.ReservasAlquilerAutoEntity != null)
                {
                    ReservasAlquilerAutoRules ra = new ReservasAlquilerAutoRules();
                    det.IdReservaAlquilerAuto = ra.Agregar(det.ReservasAlquilerAutoEntity.IdDestino,det.ReservasAlquilerAutoEntity.CantPasajeros,det.ReservasAlquilerAutoEntity.Marca,det.ReservasAlquilerAutoEntity.Modelo,det.ReservasAlquilerAutoEntity.FechaDesde,det.ReservasAlquilerAutoEntity.FechaHasta,det.ReservasAlquilerAutoEntity.Precio);

                }

                if (det.ReservasHotelEntity != null)
                {
                    ReservasHotelRules rh = new ReservasHotelRules();
                    det.IdReservaHotel = rh.Agregar(det.ReservasHotelEntity.IdDestino,det.ReservasHotelEntity.CantHabitaciones,det.ReservasHotelEntity.CantPasajeros,det.ReservasHotelEntity.IdHotel,det.ReservasHotelEntity.CodigoReserva,det.ReservasHotelEntity.Precio,det.ReservasHotelEntity.Checkin,det.ReservasHotelEntity.Checkout);

                }

                det.IdSolicitud = pf.IdSolicitud;
                SolicitudesDetalleMapper.Instance().Insert(det);
            }
        }


        public void Modificar(int IdSolicitud, DateTime Fecha, int IdUsuario, int IdSolicitudEstado, string EmailCopia, string Descripcion)
        {

            Validar(Fecha, IdUsuario);
            Solicitudes pf = SolicitudesMapper.Instance().GetOne(IdSolicitud);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }
            pf.Fecha = Fecha;
            pf.IdUsuario = IdUsuario;
            pf.IdSolicitudEstado = IdSolicitudEstado;
            pf.EmailCopia = EmailCopia;
            pf.Descripcion = Descripcion;

            SolicitudesMapper.Instance().Save(pf);
        }

        
        public void Eliminar(int IdSolicitud)
        {
            // Aca habiamos acordado que hacemos borrado fisico, hacemos borrado logico, el campo que maneja es es el activo.
            Solicitudes pf = SolicitudesMapper.Instance().GetOne(IdSolicitud);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud que ingresaste.");
            }

            SolicitudesMapper.Instance().Delete(pf);

        }

        private void Validar(DateTime Fecha, int IdUsuario)
        {
            if (Fecha.GetHashCode() == 0) { throw new Exception("Debe ingresar la Fecha de la Solicitud"); }

            if (Fecha < DateTime.Today) { throw new Exception("La Fecha de la solicitud debe ser actual o posterior"); }

            //aca me fijo que el usuario exista
            dsIntranet intra = new dsIntranet();
            dsIntranetTableAdapters.UsuariosTableAdapter usu = new dsIntranetTableAdapters.UsuariosTableAdapter();
            usu.Fill(intra.Usuarios, IdUsuario);
            if (intra.Usuarios.Rows.Count == 0) { throw new Exception("No existe el usuario ingresado."); }

            // Como tenemos un metodo para borrar por las dudas agregamos un metodo para activar.
           
          

        }

    }
}
