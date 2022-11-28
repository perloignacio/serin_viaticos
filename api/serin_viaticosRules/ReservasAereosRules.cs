using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class ReservasAereosRules
    {
        public int Agregar( int IdOrigen, int IdDestino, int CantPasajeros, DateTime FechaViaje, bool IdaVuelta, decimal? Precio,DateTime? fechaVuelta)
        {
            Validar( IdOrigen, IdDestino, CantPasajeros, FechaViaje, IdaVuelta, Precio,"Agregar");
            ReservasAereos pf = new ReservasAereos();
            
           
            pf.IdOrigen = IdOrigen;
            pf.IdDestino = IdDestino;
            pf.CantPasajeros = CantPasajeros;
            pf.FechaViaje = FechaViaje;
            pf.IdaVuelta = IdaVuelta;
            if (Precio != null){
                pf.Precio = Precio.Value;
            }
            if (fechaVuelta.HasValue)
            {
                pf.FechaRegreso = fechaVuelta;
            }

            ReservasAereosMapper.Instance().Insert(pf);
            return pf.IdReservaAereo;
        }


        public void Modificar(int IdReservaAereo, int IdOrigen, int IdDestino, int CantPasajeros, DateTime FechaViaje, bool IdaVuelta, decimal? Precio)
        {
          
            
            ReservasAereos pf = ReservasAereosMapper.Instance().GetOne(IdReservaAereo);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            Validar( IdOrigen, IdDestino, CantPasajeros, FechaViaje, IdaVuelta, Precio,"Modificar");

            pf.IdReservaAereo = IdReservaAereo;
            pf.IdOrigen = IdOrigen;
            pf.IdDestino = IdDestino;
            pf.CantPasajeros = CantPasajeros;
            pf.FechaViaje = FechaViaje;
            pf.IdaVuelta = IdaVuelta;
            if (Precio != null)
            {
                pf.Precio = Precio.Value;
            }

            ReservasAereosMapper.Instance().Save(pf);
        }

        

        public void Eliminar(int IdReservaAereo)
        {
            ReservasAereos pf = ReservasAereosMapper.Instance().GetOne(IdReservaAereo);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaAereo que ingresaste para eliminar.");
            }
            ReservasAereosMapper.Instance().Delete(pf);
            

        }
        
        private void Validar( int IdOrigen, int IdDestino, int CantPasajeros, DateTime FechaViaje, bool IdaVuelta, decimal? Precio,string Text)
        {
            
                
            if (IdOrigen == 0) { throw new Exception("Debe ingresar un IdOrigen"); }
            if (IdDestino == 0) { throw new Exception("Debe ingresar un IdDestino"); }

            Ubicaciones pf1 = UbicacionesMapper.Instance().GetOne(IdOrigen);
            if (pf1 == null)
            {
                throw new Exception("El IdOrigen que ingresaste no existe.");
            }
            Ubicaciones pf2 = UbicacionesMapper.Instance().GetOne(IdDestino);
            if (pf2 == null)
            {
                throw new Exception("El IdDestino que ingresaste no existe.");

            }
            if (IdOrigen == IdDestino) { throw new Exception("El IdOrigen no puede ser igual al IdDestino"); }



            if (FechaViaje.GetHashCode() == 0) { throw new Exception("Debe ingresar la fecha del viaje"); }
            
            if (FechaViaje < DateTime.Today) { throw new Exception("La fecha del viaje debe ser la actual o posterior"); }

            if (CantPasajeros<1 ) { throw new Exception("Debe ingresar cantidad de pasajeros y debe ser mayor a 0"); }

            if (Precio < 1) { throw new Exception("Debe ingresar el precio y este debe ser mayor a 0"); }
        }

    }
}
