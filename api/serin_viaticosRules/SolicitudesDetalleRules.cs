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
            //    Validar(Nombre);
            SolicitudesDetalle pf = new SolicitudesDetalle();
                 
            pf.IdSolicitud = IdSolicitud;
            pf.IdSolicitudCategoria = IdSolicitudCategoria;
            if (IdReservaAereo != null){pf.IdReservaAereo = IdReservaAereo.Value;}
            if (IdResevaHotel != null) { pf.IdReservaHotel = IdResevaHotel.Value; }
            if (IdItinerario != null) { pf.IdItinerario = IdItinerario.Value; }
            if (IdReservaAlquilerAuto != null) { pf.IdReservaAlquilerAuto = IdReservaAlquilerAuto; }
            if (Observaciones != null) { pf.Observaciones = Observaciones; }

            
            
            SolicitudesDetalleMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdSolicitudDetalle, int IdSolicitud, int IdSolicitudCategoria, int? IdReservaAereo, int? IdResevaHotel, int? IdItinerario, int? IdReservaAlquilerAuto, string Observaciones)
        {

            //Validar(Nombre);
            SolicitudesDetalle pf = SolicitudesDetalleMapper.Instance().GetOne(IdSolicitudDetalle);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }
            pf.IdSolicitud = IdSolicitud;
            pf.IdSolicitudCategoria = IdSolicitudCategoria;

            if (IdReservaAereo != null) { pf.IdReservaAereo = IdReservaAereo.Value; }
            if (IdResevaHotel != null) { pf.IdReservaHotel = IdResevaHotel.Value; }
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

        private void Validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }

    }
}
