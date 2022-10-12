using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class PerfilesUsuariosRules
    {
        public void Agregar(int IdUsuario, int IdPerfil)
        {
        //
            //DEBERIAMOS VER QUE NO PUEDAS INGRESAR UN NRO DE IDPERFIL O IDUSARIO QUE NO EXISTA
            PerfilesUsuarios pu = new PerfilesUsuarios();

            //IdUsuarioPerfil es autonumerico

            pu.IdUsuario= IdUsuario;
            pu.IdPerfil = IdPerfil;
            
            PerfilesUsuariosMapper.Instance().Insert(pu);
        }


        public void Eliminar(int IdUsuario)
        {
            // ELIMINA POR IdUsuarioPerfil pero me parece deberia eliminar por idusuario
            PerfilesUsuarios pu = PerfilesUsuariosMapper.Instance().GetOne(IdUsuario);

            if (pu == null)
            {
                throw new Exception("No se encuentra el Id.");
            }
            
            PerfilesUsuariosMapper.Instance().Delete(pu);

        }


               
        public void Modificar(int IdUsuarioPerfil, int IdUsuario, int IdPerfil)        
        {
            //me fijo si el id existe 
            Validar(IdUsuario,IdPerfil);

            PerfilesUsuarios pu = PerfilesUsuariosMapper.Instance().GetOne(IdUsuarioPerfil);
            if (pu == null)
            {
                throw new Exception("No se encuentra el codigo");
            }
            pu.IdUsuario = IdUsuario;
            pu.IdPerfil = IdPerfil;

            PerfilesUsuariosMapper.Instance().Save(pu);

        }

    
        
        private void Validar(int IdUsuario, int IdPerfil)
        {

            if (IdUsuario == 0) { throw new Exception("Debe ingresar un codigo de Usuario"); }
            if (IdPerfil == 0) { throw new Exception("Debe ingresar un codigo Perfil"); }
                       

        }

    }
}
