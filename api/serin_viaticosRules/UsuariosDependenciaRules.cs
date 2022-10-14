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
            //DEBERIAMOS VER QUE NO PUEDAS INGRESAR UN NRO DE IDusuarioPadre O IDusuarioHijo QUE NO EXISTA
            UsuariosDependencia ud = new UsuariosDependencia();

            //IdDependenciaUsuario es autonumerico

            ud.IdUsuarioPadre = IdUsuarioPadre;
            ud.IdUsuarioHijo = IdUsuarioHijo;

            UsuariosDependenciaMapper.Instance().Insert(ud);
        }

                
        public void Eliminar(int IdDependenciaUsuario)
        {
            // ELIMINA POR IdDependenciaUsuario pero me parece deberia eliminar por idusuariohijo tambien idusuariopadre que eliminaria todos los hijos
            //hay que ver si un hijo puede tener vs padres
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
            Validar(IdUsuarioPadre, IdUsuarioHijo);

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

    
        
        private void Validar(int IdUsuarioPadre, int IdUsuarioHijo)
        {
            UsuariosDependencia ud = UsuariosDependenciaMapper.Instance().GetByUsuarioPadreHijo(IdUsuarioPadre, IdUsuarioHijo);
            if (ud != null)
            {
                throw new Exception("Ya existe esa relacion en la base de datos");
            }

            //Aca hay que validar por que existan los usuarios como se hace en perfiles.
            if (IdUsuarioPadre == 0) { throw new Exception("Debe ingresar un codigo Padre"); }
            if (IdUsuarioHijo == 0) { throw new Exception("Debe ingresar un codigo Hijo"); }

            

        }
        
    }
}
