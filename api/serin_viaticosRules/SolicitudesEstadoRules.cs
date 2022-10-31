using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
namespace serin_viaticosRules
{
    public class SolicitudesEstadoRules
    {
        public void Agregar(int IdSolicitudEstado,string Nombre,bool Activo)
        {
            //deberia fijarme si la solicitud existe

            /// ver como ccomprobar el ACTIVO exista


            Validar(IdSolicitudEstado,Nombre,Activo);
            SolicitudesEstados sc=new SolicitudesEstados();
            
            sc.IdSolicitudEstado= IdSolicitudEstado;
            sc.Nombre = Nombre;
            sc.Activo = true;

            SolicitudesEstadosMapper.Instance().Insert(sc);
        }

        public void Modificar(int IdSolicitudEstado, string Nombre, bool Activo)
        {

            Validar (IdSolicitudEstado, Nombre, Activo);
            SolicitudesEstados pf = SolicitudesEstadosMapper.Instance().GetOne(IdSolicitudEstado);
            if (pf == null)
            {
                throw new Exception("No se encuentra el IdSolicitudEstado");
            }
            
            //pf.IdSolicitudEstado = IdSolicitudEstado;
            pf.Nombre = Nombre;
            pf.Activo = Activo;

            SolicitudesEstadosMapper.Instance().Save(pf);

        }


        public void Activar(int IdSolicitudEstado)
        {
            // Como tenemos un metodo para borrar por las dudas agregamos un metodo para activar.
            SolicitudesEstados pf = SolicitudesEstadosMapper.Instance().GetOne(IdSolicitudEstado);

            if (pf == null)
            {
                throw new Exception("No se encuentra el IDSolicitudesEstado que ingresaste.");
            }
            pf.Activo = true;
            SolicitudesEstadosMapper.Instance().Save(pf);

        }


        public void Eliminar(int IdSolicitudEstado)
        {
            // Aca habiamos acordado que hacemos borrado fisico, hacemos borrado logico, el campo que maneja es es el activo.
            SolicitudesEstados pf = SolicitudesEstadosMapper.Instance().GetOne(IdSolicitudEstado);

            if (pf == null)
            {
                throw new Exception("No se encuentra el perfil que ingresaste.");
            }
            pf.Activo = false;
            
            SolicitudesEstadosMapper.Instance().Save(pf);

        }



        private void Validar(int IdSolicitudEstado, string Nombre, bool Activo)
        {
            if (IdSolicitudEstado == 0) { throw new Exception("Debe ingresar un codigo de IdSolicitudEstado"); }
            if (string.IsNullOrEmpty(Nombre)) { throw new Exception("Debe ingresar el Nombre"); }
            //if (Activo=='True') { throw new Exception("Debe ingresar si esta ACTIVO o no"); }
        }



    }
}
