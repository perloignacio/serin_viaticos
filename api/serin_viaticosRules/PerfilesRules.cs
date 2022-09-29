using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    class PerfilesRules
    {
        public void Agregar(int IdPerfil, string Nombre,byte   Activo, byte RequiereAutorizacion, byte Admin)
        {

            //            Validar(Codigo, Descripcion);

            
            if (PerfilesMapper.Instance().GetOne(IdPerfil) != null)
            {
                throw new Exception("El Perfil ya existe");
            }


            Perfiles pf = new Perfiles();
            
            pf.idperfil = IdPerfil;
            pf.nombre = Nombre;
            pf.activo = Activo;
            pf.requiereautorizacion= RequiereAutorizacion;
            pf.admin = Admin;

            
            PerfilesMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdPerfilBuscar, int IdPerfil, string Nombre, byte Activo, byte RequiereAutorizacion, byte Admin)        {
            Validar(Codigo, Descripcion);

        }

        public void Eliminar(int IdPerfil)
        {
            TipoGasto pf = TipoGastoMapper.Instance().GetOne(IdPerfil);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el perfil que ingresaste.");
            }
            //TipoGastoMapper.Instance().Delete(tg);

        }

        public void Validar(int IdPerfil, string Nombre, byte Activo, byte RequiereAutorizacion, byte Admin)
        {
            if (IdPerfil == 0) { throw new Exception("Debe ingresar un código."); }
            if (string.IsNullOrEmpty(Nombre)) { throw new Exception("Debe ingresar una descripción del perfil."); }
            if (RequiereAutorizacion == 0) { throw new Exception("Debe seleccionar tipo de autorización."); }
            


        }

    }
}
