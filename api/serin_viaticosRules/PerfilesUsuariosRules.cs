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
            //NO FUNCIONA PORQUE NO BUSCA SOBRE EL IDUSUARIO BUSCA POR 
            /*
            PerfilesUsuarios pu1 = PerfilesUsuariosMapper.Instance().GetOne(IdUsuario);
            if (pu1 == null)
            {
                throw new Exception("No se encuentra el codigo de usuario");
            }
            */
            
            
            
            //BUSCA EN LA TABLA LE PASAS EL IDUSUARIO Y SI NO EXISTE PASA
            
            //if (PerfilesUsuariosMapper.Instance().GetOne(IdUsuario) != null)
            //{               throw new Exception("El codigo de Usuario ya existe");            }



            //ME FIJO QUE EL IDUSUARIO EXISTA EN LA TABLA USUARIOS Y DEBO FIJARME QUE EL IDPERFIL EXITA EN LA TABLA PERFILES
            Validar (IdUsuario, IdPerfil);
            
            PerfilesUsuarios pu = new PerfilesUsuarios();

            //IdUsuarioPerfil es autonumerico

            pu.IdUsuario= IdUsuario;
            pu.IdPerfil = IdPerfil;
            
            PerfilesUsuariosMapper.Instance().Insert(pu);
        }


        public void Eliminar(int IdUsuario)
        {
            // ELIMINA POR IdUsuarioPerfil pero me parece deberia eliminar por idusuario
            PerfilesUsuariosList puList = PerfilesUsuariosMapper.Instance().GetByUsuario(IdUsuario);

            foreach (var pu in puList)
            {
                PerfilesUsuariosMapper.Instance().Delete(pu);
            }
            

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
            //aca me fijo que el usuario exista
            dsIntranet intra = new dsIntranet();
            dsIntranetTableAdapters.UsuariosTableAdapter usu = new dsIntranetTableAdapters.UsuariosTableAdapter();
            usu.Fill(intra.Usuarios, IdUsuario);
            if (intra.Usuarios.Rows.Count == 0) { throw new Exception("No existe el usuario"); }

            //aca me fijo que el PERFIL exista
            Perfiles pf = PerfilesMapper.Instance().GetOne(IdPerfil);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo de perfil");
            }

            //SI NO PONGO IDUSUARIO O IDPERFIL NO ME PERMITE UNA ALTA
            
            if (IdUsuario == 0) { throw new Exception("Debe ingresar un codigo de Usuario"); }
            if (IdPerfil == 0) { throw new Exception("Debe ingresar un codigo Perfil"); }
            

        }

    }
}
