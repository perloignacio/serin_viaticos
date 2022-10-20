using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
namespace serin_viaticosRules
{
    public class SolicitudesCategoriasRules
    {
        public void Agregar(string nombre,string email)
        {
            Validar(nombre, email);
            SolicitudesCategorias sc=new SolicitudesCategorias();
            sc.Activo = true;
            sc.EmailNotificacion = email;
            sc.Nombre = nombre;
            SolicitudesCategoriasMapper.Instance().Insert(sc);
        }


        public void Modificar(int idcategoria,string nombre, string email)
        {
            Validar(nombre, email);
            SolicitudesCategorias sc = SolicitudesCategoriasMapper.Instance().GetOne(idcategoria);
            if (sc == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            sc.EmailNotificacion = email;
            sc.Nombre = nombre;
            SolicitudesCategoriasMapper.Instance().Save(sc);


        }

        public void Activar(int idcategoria)
        {
            SolicitudesCategorias sc = SolicitudesCategoriasMapper.Instance().GetOne(idcategoria);
            if (sc == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            sc.Activo = true;
            SolicitudesCategoriasMapper.Instance().Save(sc);

        }

        public void Eliminar(int idcategoria)
        {
            SolicitudesCategorias sc = SolicitudesCategoriasMapper.Instance().GetOne(idcategoria);
            if (sc == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            sc.Activo = false;
            SolicitudesCategoriasMapper.Instance().Save(sc);

        }

        private void Validar(string nombre, string email)
        {
            if (string.IsNullOrEmpty(nombre)) { throw new Exception("Ingrese el nombre"); }
            if (string.IsNullOrEmpty(email)) { throw new Exception("Ingrese el email"); }

        }
    }
}
