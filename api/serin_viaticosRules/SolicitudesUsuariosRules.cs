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
        
        public void Agregar(int IdSolicitud, int IdUsuario, decimal? MontoAnticipo)

        {
            Validar(IdSolicitud, IdUsuario, MontoAnticipo);
            SolicitudesUsuarios pf = new SolicitudesUsuarios();

          //LO VA VER 
          //  pf.IdSolicitud = IdSolicitud;

            pf.IdUsuario = IdUsuario;
            if (MontoAnticipo != null){pf.MontoAnticipo = MontoAnticipo.Value;}
            
            SolicitudesUsuariosMapper.Instance().Insert(pf);
        }


        public void Modificar(  int IdSolicitudUsuario, int IdSolicitud, int IdUsuario, decimal? MontoAnticipo)
        {

            //Validar(Nombre);
            SolicitudesUsuarios pf = SolicitudesUsuariosMapper.Instance().GetOne(IdSolicitudUsuario);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }
            //me pone que es solo lectura y lo modifico nacho
            //pf.IdSolicitud= IdSolicitud;
            pf.IdUsuario = IdUsuario;
            if (MontoAnticipo != null) { pf.MontoAnticipo = MontoAnticipo.Value; }

            SolicitudesUsuariosMapper.Instance().Save(pf);
        }
        
        public void Eliminar(int IdSolicitudUsuario)
        {
            SolicitudesUsuarios pf = SolicitudesUsuariosMapper.Instance().GetOne(IdSolicitudUsuario);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitudUsuario que ingresaste.");
            }

            SolicitudesUsuariosMapper.Instance().Delete(pf);

        }

        private void Validar(int IdSolicitud, int IdUsuario, decimal? MontoAnticipo)
        {
            Solicitudes pf = SolicitudesMapper.Instance().GetOne(IdSolicitud);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }

            //aca me fijo que el usuario exista
            dsIntranet intra = new dsIntranet();
            dsIntranetTableAdapters.UsuariosTableAdapter usu = new dsIntranetTableAdapters.UsuariosTableAdapter();
            usu.Fill(intra.Usuarios, IdUsuario);
            if (intra.Usuarios.Rows.Count == 0) { throw new Exception("No existe el usuario ingresado."); }



        }

    }
}
