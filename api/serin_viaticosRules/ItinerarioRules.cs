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
        public void Agregar(DateTime Fecha, bool IdaVuelta)
        {

            

            //IDAVUELTA SI NO SE PASA EL DATO LO CARGA COMO FALSE
            Validar(Fecha);
            Itinerario pf = new Itinerario();

            
            pf.Fecha = Fecha;
            //porque en este caso se debe definir si hay ida y vuelta o no no ponerlo como true siempre
            //pf.IdaVuelta = true;
            pf.IdaVuelta = IdaVuelta ;

            ItinerarioMapper.Instance().Insert(pf);
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
            //if (Fecha.HasValue){ throw new Exception("Debe ingresar la Fecha"); }
            //if (string.IsNullOrEmpty(IdaVuelta)){ throw new Exception("Debe ingresar el nombre"); }
            //if (DateTime.TryParse("texto a validar", out Fecha))
            //if (DateTime.TryParse(Fecha, out Fecha))

        }
        
    }
}
