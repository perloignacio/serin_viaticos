using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class SolicitudesDetalleRules
    {
        public void Agregar(int IdSolicitud, int IdSolicitudCategoria, int? IdReservaAereo, int? IdResevaHotel, int? IdItinerario, int? IdReservaAlquilerAuto, string Observaciones)

        {
            Validar(IdSolicitud, IdSolicitudCategoria, IdReservaAereo, IdResevaHotel, IdItinerario, IdReservaAlquilerAuto);
            //Validar(IdSolicitud, IdSolicitudCategoria);
            SolicitudesDetalle pf = new SolicitudesDetalle();
                 
            pf.IdSolicitud = IdSolicitud;
            pf.IdSolicitudCategoria = IdSolicitudCategoria;
            if (IdReservaAereo != null){pf.IdReservaAereo = IdReservaAereo.Value;}
            if (IdResevaHotel != null) { pf.IdResevaHotel = IdResevaHotel.Value; }
            if (IdItinerario != null) { pf.IdItinerario = IdItinerario.Value; }
            if (IdReservaAlquilerAuto != null) { pf.IdReservaAlquilerAuto = IdReservaAlquilerAuto; }
            if (Observaciones != null) { pf.Observaciones = Observaciones; }

            SolicitudesDetalleMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdSolicitudDetalle, int IdSolicitud, int IdSolicitudCategoria, int? IdReservaAereo, int? IdResevaHotel, int? IdItinerario, int? IdReservaAlquilerAuto, string Observaciones)
        {
            
            Validar(IdSolicitud, IdSolicitudCategoria, IdReservaAereo, IdResevaHotel, IdItinerario, IdReservaAlquilerAuto);
            SolicitudesDetalle pf = SolicitudesDetalleMapper.Instance().GetOne(IdSolicitudDetalle);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }

            pf.IdSolicitud = IdSolicitud;
            pf.IdSolicitudCategoria = IdSolicitudCategoria;
            
            if (IdReservaAereo != null) { pf.IdReservaAereo = IdReservaAereo.Value; }
            if (IdResevaHotel != null) { pf.IdResevaHotel = IdResevaHotel.Value; }
            if (IdItinerario != null) { pf.IdItinerario = IdItinerario.Value; }
            if (Observaciones != null) { pf.Observaciones = Observaciones; }
            if (IdReservaAlquilerAuto != null) { pf.IdReservaAlquilerAuto = IdReservaAlquilerAuto; }

            SolicitudesDetalleMapper.Instance().Save(pf);
        }

        
        public void Eliminar(int IdSolicitudDetalle)
        {
            SolicitudesDetalle pf = SolicitudesDetalleMapper.Instance().GetOne(IdSolicitudDetalle);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud que ingresaste.");
            }

            SolicitudesDetalleMapper.Instance().Delete(pf);

        }

       private void Validar(int IdSolicitud, int IdSolicitudCategoria, int? IdReservaAereo, int? IdResevaHotel, int? IdItinerario, int? IdReservaAlquilerAuto)
       //private void Validar(int IdSolicitud, int IdSolicitudCategoria)
        {
            if (IdSolicitud <= 0) { throw new Exception("Debe ingresar un IdSolicitud"); }
            Solicitudes pf = SolicitudesMapper.Instance().GetOne(IdSolicitud);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }


            if (IdSolicitudCategoria <= 0) { throw new Exception("Debe ingresar un IdSolicitudCategoria valido"); }
            SolicitudesCategorias sc = SolicitudesCategoriasMapper.Instance().GetOne(IdSolicitudCategoria);
            if (sc == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            if (IdReservaAereo <= 0) { throw new Exception("Debe ingresar un IdReservaAereo valido"); }
            if (IdReservaAereo.HasValue)
            {
                ReservasAereos pf1 = ReservasAereosMapper.Instance().GetOne(IdReservaAereo.Value);
                if (pf1 == null) { throw new Exception("No se encuentra el IdReservaAereo"); }
            }

            if (IdResevaHotel <= 0) { throw new Exception("Debe ingresar un IdResevaHotel valido"); }
            if (IdResevaHotel.HasValue)
            {
                ReservasHotel pf2 = ReservasHotelMapper.Instance().GetOne(IdResevaHotel.Value);
                if (pf2 == null) { throw new Exception("No se encuentra el IdReservaHotel"); }
            }

            
            if (IdItinerario <= 0) { throw new Exception("Debe ingresar un IdItinerario valido"); }
            if (IdItinerario.HasValue)
            {
                Itinerario pf3 = ItinerarioMapper.Instance().GetOne(IdItinerario.Value);
                if (pf3 == null) { throw new Exception("No se encuentra el IdItinerario"); }
            }
           
            if (IdReservaAlquilerAuto <= 0) { throw new Exception("Debe ingresar un IdReservaAlquilerAuto valido"); }
            if (IdReservaAlquilerAuto.HasValue)
            {
                ReservasAlquilerAuto pf4 = ReservasAlquilerAutoMapper.Instance().GetOne(IdReservaAlquilerAuto.Value);
                if (pf4 == null) { throw new Exception("No se encuentra el IdReservaAlquilerAuto"); }
            }

        }

    }
}
