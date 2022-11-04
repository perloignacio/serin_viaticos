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
        //    Validar(Nombre);
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

            //Validar(Nombre);
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

        private void Validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre)){ throw new Exception("Debe ingresar el nombre"); }
            
        }

    }
}
