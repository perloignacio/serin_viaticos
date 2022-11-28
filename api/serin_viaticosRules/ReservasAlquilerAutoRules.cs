using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serin_viaticosRules
{
    public class ReservasAlquilerAutoRules
    {
        public int Agregar(int IdDestino, int CantPasajeros, string Marca, string Modelo, DateTime FechaDesde, DateTime FechaHasta, decimal? Precio)
        {
            
            Validar(IdDestino, CantPasajeros, Marca, Modelo, FechaDesde, FechaHasta,Precio);
            ReservasAlquilerAuto pf = new ReservasAlquilerAuto();

            pf.IdDestino = IdDestino;
            pf.CantPasajeros = CantPasajeros;
            pf.Marca = Marca;
            pf.Modelo = Modelo;
            pf.FechaDesde = FechaDesde;
            pf.FechaHasta = FechaHasta;
            if (Precio != null) { pf.Precio = Precio; }

            ReservasAlquilerAutoMapper.Instance().Insert(pf);
            return pf.IdReservaAlquilerAuto;
        }

      

        public void Modificar(int IdReservaAlquilerAuto,int IdDestino, int CantPasajeros, string Marca, string Modelo, DateTime FechaDesde, DateTime FechaHasta, decimal? Precio)
        {
            Validar(IdDestino, CantPasajeros, Marca, Modelo, FechaDesde, FechaHasta, Precio);
            
            ReservasAlquilerAuto pf = ReservasAlquilerAutoMapper.Instance().GetOne(IdReservaAlquilerAuto);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaAlquilerAuto");
            }

            pf.IdDestino = IdDestino;
            pf.CantPasajeros = CantPasajeros;
            pf.Marca = Marca;
            pf.Modelo = Modelo;
            pf.FechaDesde = FechaDesde;
            pf.FechaHasta = FechaHasta;
            if (Precio != null) { 
                pf.Precio = Precio;
                }
            else { }

            ReservasAlquilerAutoMapper.Instance().Save(pf);
        }

        public void Eliminar(int IdReservaAlquilerAuto)
        {
            ReservasAlquilerAuto pf = ReservasAlquilerAutoMapper.Instance().GetOne(IdReservaAlquilerAuto);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdReservaAlquilerAuto que ingresaste.");
            }
            ReservasAlquilerAutoMapper.Instance().Delete(pf);
            

        }

        private void Validar( int IdDestino, int CantPasajeros, string Marca, string Modelo, DateTime FechaDesde, DateTime FechaHasta, decimal? Precio)
        {
            if (IdDestino == 0) { throw new Exception("Debe ingresar un IdDestino"); }

            Ubicaciones pf = UbicacionesMapper.Instance().GetOne(IdDestino);
                if (pf == null)
                {
                    throw new Exception("No se encuentra el IdDestino que ingresaste.");
                }

            if (CantPasajeros < 1) { throw new Exception("Debe ingresar cantidad de pasajeros y debe ser mayor a 0"); }


            if (FechaDesde.GetHashCode() == 0) { throw new Exception("Debe ingresar la FechaDesde del alquiler"); }

            if (FechaDesde < DateTime.Today) { throw new Exception("La FechaDesde del alquiler debe ser actual o posterior"); }

            if (FechaHasta.GetHashCode() == 0) { throw new Exception("Debe ingresar la FechaHasta del alquiler"); }

            if (FechaDesde > FechaHasta) { throw new Exception("La FechaDesde debe ser igual o menor a la FechaHasta"); }


            if (Precio < 1) { throw new Exception("Debe ingresar el precio y este debe ser mayor a 0"); }


        }
        
    }
}


