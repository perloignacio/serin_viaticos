using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class SolicitudesUsuariosRules
    {
        /*
        public void Agregar(int IdSolicitudUsuario, int IdUsuario, decimal? MontoAnticipo)

        {
            //    Validar(Nombre);
            SolicitudesUsuarios pf = new SolicitudesUsuarios();
                 
            pf.IdSolicitudUsuario = IdSolicitudUsuario;
            pf.IdUsuario = IdUsuario;
            if (MontoAnticipo != null){pf.MontoAnticipo = MontoAnticipo.Value;}
            
            SolicitudesUsuariosMapper.Instance().Insert(pf);
        }


        public void Modificar( int IdSolicitud, int IdSolicitudUsuario, int IdUsuario, decimal? MontoAnticipo)
        {

            //Validar(Nombre);
            SolicitudesUsuarios pf = SolicitudesUsuariosMapper.Instance().GetOne(IdSolicitudUsuario);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }
            pf.IdSolicitudUsuario = IdSolicitudUsuario;

            pf.IdUsuario = IdUsuario;
            if (MontoAnticipo != null) { pf.MontoAnticipo = MontoAnticipo.Value; }

            SolicitudesUsuariosMapper.Instance().Save(pf);
        }

        
        public void Eliminar(int IdSolicitud)
        {
            SolicitudesUsuarios pf = SolicitudesUsuariosMapper.Instance().GetOne(IdSolicitud);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitudUsuario que ingresaste.");
            }

            SolicitudesUsuariosMapper.Instance().Delete(pf);

        }

        private void Validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }
*/
    }
}
