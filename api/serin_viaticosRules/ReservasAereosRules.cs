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
        public void Agregar(int IdReservaAereo, int IdOrigen, int IdDestino, int CantPasajeros, DateTime FechaViaje, bool IdaVuelta, decimal? Precio)
        {
            //Validar(Nombre);
            ReservasAereos pf = new ReservasAereos();
            
            pf.IdReservaAereo = IdReservaAereo;
            pf.IdOrigen = IdOrigen;
            pf.IdDestino = IdDestino;
            pf.CantPasajeros = CantPasajeros;
            pf.FechaViaje = FechaViaje;
            pf.IdaVuelta = IdaVuelta;
            if (Precio != null){
                pf.Precio = Precio.Value;
            }

            ReservasAereosMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdReservaAereo, int IdOrigen, int IdDestino, int CantPasajeros, DateTime FechaViaje, bool IdaVuelta, decimal? Precio)
        {

            //Validar(Nombre);
            ReservasAereos pf = ReservasAereosMapper.Instance().GetOne(IdReservaAereo);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }

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
                throw new Exception("No se encuentra el IdReservaAereo que ingresaste.");
            }
            ReservasAereosMapper.Instance().Delete(pf);
            

        }

        private void Validar(int IdReservaAereo, int IdOrigen, int IdDestino)
        {
            //QUEDS PENDIENTE HASTA QUE HAGA LA CLASE UBIUCACIONES
            //La FECHA DE VIAJE SEA PORSTERIOR A LA FECHA ACTUAL
            //IDORIGEN Y DESTINO EXISTAN 
            Ubicaciones pf = UbicacionesMapper.Instance().GetOne(IdReservaAereo);

            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaAereo que ingresaste.");
            }

            //if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }

    }
}
