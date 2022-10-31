using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class UbicacionesRules
    {
        public void Agregar(string Nombre,Int64 Lat, Int64 Lng)
        {
            Validar(Nombre);
            Ubicaciones pf = new Ubicaciones();
            
            pf.Nombre = Nombre;
            pf.Lat= Lat;
            pf.Lng = Lng;
            UbicacionesMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdUbicacion, string Nombre, Int64 Lat, Int64 Lng)
        {
            Validar(Nombre);

            Ubicaciones pf = UbicacionesMapper.Instance().GetOne(IdUbicacion);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            pf.Nombre = Nombre;
            pf.Lat = Lat;
            pf.Lng = Lng;
            UbicacionesMapper.Instance().Save(pf);
        }

        public void Eliminar(int IdUbicacion)
        {
            // Aca habiamos acordado que hacemos borrado fisico, hacemos borrado logico, el campo que maneja es es el activo.
            Ubicaciones pf = UbicacionesMapper.Instance().GetOne(IdUbicacion);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el perfil que ingresaste.");
            }

            UbicacionesMapper.Instance().Delete(pf);

        }
        
        private void Validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }
        
    }
}
