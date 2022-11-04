using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class ReservasHotelRules
    {
        
        public void Agregar(int IdDestino, int CantHabitaciones, int CantPasajeros, int IdHotel, string CodigoReserva, decimal? Precio, DateTime Checkin, DateTime Checkout)
        {
            //Validar(Nombre);
            ReservasHotel pf = new ReservasHotel();

            pf.IdDestino = IdDestino;
            pf.CantHabitaciones = CantHabitaciones;
            pf.CantPasajeros = CantPasajeros;
            pf.IdHotel = IdHotel;
            pf.CodigoReserva = CodigoReserva;
            if (Precio != null) { pf.Precio = Precio; }
            pf.Checkin = Checkin;
            pf.Checkout = Checkout;


            ReservasHotelMapper.Instance().Insert(pf);
        }

        
        public void Modificar(int IdReservaHotel, int IdDestino, int CantHabitaciones, int CantPasajeros, int IdHotel, string CodigoReserva, decimal? Precio, DateTime Checkin, DateTime Checkout)
        {

            //Validar(Nombre);
            ReservasHotel pf = ReservasHotelMapper.Instance().GetOne(IdReservaHotel);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaHotel");
            }

            pf.IdDestino = IdDestino;
            pf.CantHabitaciones = CantHabitaciones;
            pf.CantPasajeros = CantPasajeros;
            pf.IdHotel = IdHotel;
            pf.CodigoReserva = CodigoReserva;
            if (Precio != null) { pf.Precio = Precio; }
            pf.Checkin = Checkin;
            pf.Checkout = Checkout;


            ReservasHotelMapper.Instance().Save(pf);
        }

        public void Eliminar(int IdReservaHotel)
        {
            ReservasHotel pf = ReservasHotelMapper.Instance().GetOne(IdReservaHotel);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaHotel que ingresaste.");
            }
            ReservasHotelMapper.Instance().Delete(pf);

        }

        private void Validar(int IdReservaAlquilerAuto, int IdDestino)
        {
            //QUEDS PENDIENTE HASTA QUE HAGA LA CLASE UBIUCACIONES
            //La FECHA DE VIAJE SEA PORSTERIOR A LA FECHA ACTUAL
            //IDORIGEN Y DESTINO EXISTAN 
            Ubicaciones pf = UbicacionesMapper.Instance().GetOne(IdReservaAlquilerAuto);

            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaAereo que ingresaste.");
            }

            //if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }
        
    }
}
