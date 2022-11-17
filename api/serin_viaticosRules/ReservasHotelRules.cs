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
            Validar(IdDestino, CantHabitaciones, CantPasajeros, IdHotel, CodigoReserva, Precio, Checkin, Checkout);
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

        private void Validar(int IdDestino, int CantHabitaciones, int CantPasajeros, int IdHotel, string CodigoReserva, decimal? Precio, DateTime Checkin, DateTime Checkout)
        {
            if (IdDestino == 0) { throw new Exception("Debe ingresar un IdDestino"); }

            Ubicaciones pf1 = UbicacionesMapper.Instance().GetOne(IdDestino);
            if (pf1 == null)
            {
                throw new Exception("No se encuentra el IdDestino que ingresaste.");
            }

            if (CantHabitaciones < 1) { throw new Exception("Debe ingresar cantidad de habitaciones y debe ser mayor a 0"); }
            if (CantPasajeros < 1) { throw new Exception("Debe ingresar cantidad de pasajeros y debe ser mayor a 0"); }

            Hoteles pf = HotelesMapper.Instance().GetOne(IdHotel);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdHotel");
            }


            if (Checkin.GetHashCode() == 0) { throw new Exception("Debe ingresar la FechaCheckin del Hotel"); }

            if (Checkin < DateTime.Today) { throw new Exception("La FechaCheckin del alquiler debe ser actual o posterior"); }

            if (Checkout.GetHashCode() == 0) { throw new Exception("Debe ingresar la Checkout del Hotel"); }

            if (Checkin > Checkout) { throw new Exception("La Checkout debe ser igual o menor a la Checkin"); }


            if (Precio < 0) { throw new Exception("Debe ingresar el precio y este debe ser mayor a 0"); }



            
        }

    }
}
