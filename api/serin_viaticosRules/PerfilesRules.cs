using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class PerfilesRules
    {
        public void Agregar(string Nombre,bool Activo, bool RequiereAutorizacion, bool Admin)
        {
            Perfiles pf = new Perfiles();
            pf.Nombre = Nombre;
            pf.Activo = Activo;
            pf.RequiereAutorizacion= RequiereAutorizacion;
            pf.Admin = Admin;
            PerfilesMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdPerfil, string Nombre, bool Activo, bool RequiereAutorizacion, bool Admin)        
        {
            
            //me fijo si el id existe y si es tiene algo escrito
            Validar(IdPerfil);

        }

        public void Eliminar(int IdPerfil)
        {
            Perfiles pf = PerfilesMapper.Instance().GetOne(IdPerfil);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el perfil que ingresaste.");
            }
            PerfilesMapper.Instance().Delete(pf);

        }

        public void Validar(int IdPerfil)
        {
            if (IdPerfil == 0) { throw new Exception("Debe ingresar un código."); }
            
            
            //if (string.IsNullOrEmpty(Nombre)) { throw new Exception("Debe ingresar una descripción del perfil."); }
            //if (RequiereAutorizacion == true)  { throw new Exception("Debe seleccionar tipo de autorización."); }
            


        }

    }
}
