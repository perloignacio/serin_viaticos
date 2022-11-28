using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class ItinerarioRules
    {
        public int Agregar(DateTime Fecha, bool IdaVuelta,DateTime? fechaVuelta,decimal? km, List<ItinerarioDetalle> detalle)
        {
            //IDAVUELTA SI NO SE PASA EL DATO LO CARGA COMO FALSE
            Validar(Fecha);
            Itinerario pf = new Itinerario();
           
            pf.Fecha = Fecha;
            pf.FechaVuelta = fechaVuelta;
            pf.IdaVuelta = IdaVuelta;
            pf.Km = km;
            pf.IdaVuelta = IdaVuelta ;

            ItinerarioMapper.Instance().Insert(pf);
            foreach (var item in detalle)
            {
                item.IdItinerario = pf.IdItinerario;
                ItinerarioDetalleMapper.Instance().Insert(item);
            }

            return pf.IdItinerario;
        }

        public void Eliminar(int IdItinerario)
        {
            // Aca habiamos acordado que hacemos borrado fisico, hacemos borrado logico, el campo que maneja es es el activo.
            Itinerario pf = ItinerarioMapper.Instance().GetOne(IdItinerario);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdItinerario que ingresaste.");
            }
            //            pf.Activo = false;
            //          ItinerarioMapper.Instance().Save(pf);
            ItinerarioMapper.Instance().Delete(pf);

        }
                
        public void Modificar(int IdItinerario, DateTime Fecha, bool IdaVuelta)
        {
            // el id es autonumerico y si es tiene algo escrito
            Validar(Fecha);
            Itinerario pf = ItinerarioMapper.Instance().GetOne(IdItinerario);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            pf.Fecha = Fecha;
            pf.IdaVuelta = IdaVuelta;

            ItinerarioMapper.Instance().Save(pf);

        }
             
        
        private void Validar(DateTime Fecha)
        {
            if (Fecha.GetHashCode() == 0) { throw new Exception("Debe ingresar la Fecha"); }
            if (Fecha < DateTime.Today) { throw new Exception("Debe ingresar la fecha actual o posterior"); }

        }
        
    }
}
