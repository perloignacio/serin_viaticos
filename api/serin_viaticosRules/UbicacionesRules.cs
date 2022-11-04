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
        public void Agregar(string Nombre,decimal? Lat, decimal? Lng)
        {
            Validar(Nombre);
            Ubicaciones pf = new Ubicaciones();
            
            pf.Nombre = Nombre;
            if (Lat != null){
                pf.Lat= Lat.Value;
            }
            if (Lng != null)
            {
                pf.Lng = Lng.Value;
            }
            UbicacionesMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdUbicacion, string Nombre, decimal? Lat, decimal? Lng)
        {
            Validar(Nombre);

            Ubicaciones pf = UbicacionesMapper.Instance().GetOne(IdUbicacion);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            pf.Nombre = Nombre;
            if (Lat != null)
            {
                pf.Lat = Lat.Value;
            }
            if (Lng != null)
            {
                pf.Lng = Lng.Value;
            }

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
