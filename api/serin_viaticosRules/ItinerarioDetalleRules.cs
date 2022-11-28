using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class ItinerarioDetalleRules
    {
        public void Agregar(int IdItinerario, int IdUbicacion)
        {
            Validar(IdItinerario, IdUbicacion);
            ItinerarioDetalle pf = new ItinerarioDetalle();

            
            pf.IdItinerario = IdItinerario;
            pf.IdParada = IdUbicacion;

            ItinerarioDetalleMapper.Instance().Insert(pf);
        }

        public void Eliminar(int IdItinerarioDetalle)
        {
            ItinerarioDetalle pf = ItinerarioDetalleMapper.Instance().GetOne(IdItinerarioDetalle);

            if (pf == null)
            {
                throw new Exception("No se encuentra el IdItinerario que ingresaste.");
            }
            
            ItinerarioDetalleMapper.Instance().Delete(pf);

        }
                
        public void Modificar(int IdItinerarioDetalle,int IdItinerario, int IdUbicacion)
        {
            Validar(IdItinerario, IdUbicacion);
            ItinerarioDetalle pf = ItinerarioDetalleMapper.Instance().GetOne(IdItinerarioDetalle);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            pf.IdItinerario = IdItinerario;
            pf.IdParada = IdUbicacion;


            ItinerarioDetalleMapper.Instance().Save(pf);

        }
             
        
        private void Validar(int IdItinerario,int IdUbicacion)
        {
            //ME FIJO EN LA TABLA DE ITINERARIOS QUE EXISTA EL ID QUE SE CARGA
            Itinerario pf = ItinerarioMapper.Instance().GetOne(IdItinerario);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdItinerario");
            }
                        
            if (IdItinerario == 0) { throw new Exception("Debe ingresar un IdItinerario"); }
            if (IdUbicacion == 0) { throw new Exception("Debe ingresar un parada"); }
            

            

        }

    }
}
