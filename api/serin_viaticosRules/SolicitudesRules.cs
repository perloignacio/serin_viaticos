using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class SolicitudesRules
    {
        public void Agregar(DateTime Fecha, int IdUsuario, int IdSolicituEstado,string EmailCopia, string Descripcion)
        {
            Validar(Fecha, IdUsuario, IdSolicituEstado);
            Solicitudes pf = new Solicitudes();
                 
            pf.Fecha = Fecha;
            pf.IdUsuario = IdUsuario;
            pf.IdSolicituEstado = IdSolicituEstado;
            pf.EmailCopia = EmailCopia;
            pf.Descripcion = Descripcion;

            SolicitudesMapper.Instance().Insert(pf);
        }


        public void Modificar(int IdSolicitud, DateTime Fecha, int IdUsuario, int IdSolicituEstado, string EmailCopia, string Descripcion)
        {

            Validar(Fecha, IdUsuario, IdSolicituEstado);
            Solicitudes pf = SolicitudesMapper.Instance().GetOne(IdSolicitud);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud");
            }
            pf.Fecha = Fecha;
            pf.IdUsuario = IdUsuario;
            pf.IdSolicituEstado = IdSolicituEstado;
            pf.EmailCopia = EmailCopia;
            pf.Descripcion = Descripcion;

            SolicitudesMapper.Instance().Save(pf);
        }

        
        public void Eliminar(int IdSolicitud)
        {
            // Aca habiamos acordado que hacemos borrado fisico, hacemos borrado logico, el campo que maneja es es el activo.
            Solicitudes pf = SolicitudesMapper.Instance().GetOne(IdSolicitud);
            
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitud que ingresaste.");
            }

            SolicitudesMapper.Instance().Delete(pf);

        }

        private void Validar(DateTime Fecha, int IdUsuario, int IdSolicituEstado)
        {
            if (Fecha.GetHashCode() == 0) { throw new Exception("Debe ingresar la Fecha de la Solicitud"); }

            if (Fecha < DateTime.Today) { throw new Exception("La Fecha de la solicitud debe ser actual o posterior"); }

            //aca me fijo que el usuario exista
            dsIntranet intra = new dsIntranet();
            dsIntranetTableAdapters.UsuariosTableAdapter usu = new dsIntranetTableAdapters.UsuariosTableAdapter();
            usu.Fill(intra.Usuarios, IdUsuario);
            if (intra.Usuarios.Rows.Count == 0) { throw new Exception("No existe el usuario ingresado."); }

            // Como tenemos un metodo para borrar por las dudas agregamos un metodo para activar.
            SolicitudesEstados pf = SolicitudesEstadosMapper.Instance().GetOne(IdSolicituEstado);

            if (pf == null)
            {
                throw new Exception("No se encuentra el IDSolicitudesEstado que ingresaste.");
            }

          

        }

    }
}
