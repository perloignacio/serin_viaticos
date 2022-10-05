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
        public void Agregar(string Nombre, bool RequiereAutorizacion, bool Admin)
        {
            Validar(Nombre);
            Perfiles pf = new Perfiles();
            
            pf.Nombre = Nombre;
            //El activo a la hora de crear lo seteamos en true
            pf.Activo = true;
            pf.RequiereAutorizacion= RequiereAutorizacion;
            pf.Admin = Admin;
            PerfilesMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdPerfil, string Nombre, bool RequiereAutorizacion, bool Admin)        
        {

            //me fijo si el id existe y si es tiene algo escrito

            Validar(Nombre);
            Perfiles pf = PerfilesMapper.Instance().GetOne(IdPerfil);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            pf.Nombre = Nombre;
            //El activo no se toca, es un estado que lo maneja el metodo borrar / activar
            pf.RequiereAutorizacion = RequiereAutorizacion;
            pf.Admin = Admin; 
            
            PerfilesMapper.Instance().Save(pf);

        }

        public void Activar(int IdPerfil)
        {
            // Como tenemos un metodo para borrar por las dudas agregamos un metodo para activar.
            Perfiles pf = PerfilesMapper.Instance().GetOne(IdPerfil);

            if (pf == null)
            {
                throw new Exception("No se encuentra el perfil que ingresaste.");
            }
            pf.Activo = true;
            PerfilesMapper.Instance().Save(pf);

        }

        public void Eliminar(int IdPerfil)
        {
            // Aca habiamos acordado que hacemos borrado fisico, hacemos borrado logico, el campo que maneja es es el activo.
            Perfiles pf = PerfilesMapper.Instance().GetOne(IdPerfil);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el perfil que ingresaste.");
            }
            pf.Activo = false;
            PerfilesMapper.Instance().Save(pf);

        }

        public void Validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }

    }
}
