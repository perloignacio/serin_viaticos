using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class UsuariosDependenciaRules
    {
     
        public void Agregar(int IdUsuarioPadre, int IdUsuarioHijo)
        {
            
            Validar(IdUsuarioPadre, IdUsuarioHijo,"Agregar");


            UsuariosDependencia ud = new UsuariosDependencia();

           

            ud.IdUsuarioPadre = IdUsuarioPadre;
            ud.IdUsuarioHijo = IdUsuarioHijo;

            UsuariosDependenciaMapper.Instance().Insert(ud);
        }

                
        public void Eliminar(int IdDependenciaUsuario)
        {
           
            UsuariosDependencia ud = UsuariosDependenciaMapper.Instance().GetOne(IdDependenciaUsuario);

            if (ud == null)
            {
                throw new Exception("No se encuentra el Id.");
            }

            UsuariosDependenciaMapper.Instance().Delete(ud);

        }

               
        public void Modificar(int IdDependenciaUsuario, int IdUsuarioPadre, int IdUsuarioHijo)        
        {
            //me fijo si el id existe y si es tiene algo escrito
            Validar(IdUsuarioPadre, IdUsuarioHijo,"Modificar");

            //podria buscar por idpadre y dentro de este el hijo
            UsuariosDependencia ud = UsuariosDependenciaMapper.Instance().GetOne(IdDependenciaUsuario);
            if (ud == null)
            {
                throw new Exception("No se encuentra el codigo");
            }

            ud.IdUsuarioPadre = IdUsuarioPadre;
            ud.IdUsuarioHijo = IdUsuarioHijo;


            UsuariosDependenciaMapper.Instance().Save(ud);

        }

    
        
        private void Validar(int IdUsuarioPadre, int IdUsuarioHijo,string accion)
        { 
            //Aca hay que validar por que existan los usuarios como se hace en perfiles.
            if (IdUsuarioPadre == 0) { throw new Exception("Debe ingresar un codigo Padre"); }
            if (IdUsuarioHijo == 0) { throw new Exception("Debe ingresar un codigo Hijo"); }

            //aca me fijo que el usuario exista
            dsIntranet intra = new dsIntranet();
            dsIntranetTableAdapters.UsuariosTableAdapter usu = new dsIntranetTableAdapters.UsuariosTableAdapter();
            usu.Fill(intra.Usuarios, IdUsuarioPadre);
            if (intra.Usuarios.Rows.Count == 0) { throw new Exception("No existe el usuario PADRE"); }


            //aca me fijo que el usuario exista
            usu.Fill(intra.Usuarios, IdUsuarioHijo);
            if (intra.Usuarios.Rows.Count == 0) { throw new Exception("No existe el usuario HIJO"); }





            
            UsuariosDependencia ud = UsuariosDependenciaMapper.Instance().GetByUsuarioPadreHijo(IdUsuarioPadre, IdUsuarioHijo);
            if (ud != null)
            {
                throw new Exception("Ya existe esa relacion en la base de datos");
            }

            if (accion != "Modificar")
            {
                ud = UsuariosDependenciaMapper.Instance().GetPadreByHijo(IdUsuarioHijo);
                if (ud != null)
                {
                    throw new Exception("El usuario ya tiene asignado un responsable");
                }

            }
            

                       

        }
        
    }
}
