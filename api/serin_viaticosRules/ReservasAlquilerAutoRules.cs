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
        public void Agregar(int IdDestino, int CantPasajeros,string Marca, string Modelo,  DateTime FechaDesde, DateTime FechaHasta, decimal Precio)
        {
            //Validar(Nombre);
            ReservasAlquilerAuto pf = new ReservasAlquilerAuto();

            pf.IdDestino = IdDestino;
            pf.CantPasajeros = CantPasajeros;
            pf.Marca = Marca;
            pf.Modelo = Modelo;
            pf.FechaDesde = FechaDesde;
            pf.FechaHasta = FechaHasta;
            if (Precio != null) { pf.Precio = Precio; }

            ReservasAlquilerAutoMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdReservaAlquilerAuto,int IdDestino, int CantPasajeros, string Marca, string Modelo, DateTime FechaDesde, DateTime FechaHasta, decimal Precio)
        {
            
            //Validar(Nombre);
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
