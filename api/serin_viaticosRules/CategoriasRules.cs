using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
namespace serin_viaticosRules
{
    public class CategoriasRules
    {
        public void Agregar(string nombre,string email)
        {
            Validar(nombre, email);
            CategoriasGasto cg=new CategoriasGasto();
            cg.Activo = true;
            cg.EmailNotificacion = email;
            cg.Nombre = nombre;
            CategoriasGastoMapper.Instance().Insert(cg);
        }


        public void Modificar(int idcategoria,string nombre, string email)
        {
            Validar(nombre, email);
            CategoriasGasto cg = CategoriasGastoMapper.Instance().GetOne(idcategoria);
            if (cg == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            cg.EmailNotificacion = email;
            cg.Nombre = nombre;
            CategoriasGastoMapper.Instance().Save(cg);


        }

        public void Activar(int idcategoria)
        {
            CategoriasGasto cg = CategoriasGastoMapper.Instance().GetOne(idcategoria);
            if (cg == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            cg.Activo = true;
            CategoriasGastoMapper.Instance().Save(cg);

        }

        public void Eliminar(int idcategoria)
        {
            CategoriasGasto cg = CategoriasGastoMapper.Instance().GetOne(idcategoria);
            if (cg == null)
            {
                throw new Exception("La categoria no se encuentra");
            }

            cg.Activo = false;
            CategoriasGastoMapper.Instance().Save(cg);

        }

        private void Validar(string nombre, string email)
        {
            if (string.IsNullOrEmpty(nombre)) { throw new Exception("Ingrese el nombre"); }
            if (string.IsNullOrEmpty(email)) { throw new Exception("Ingrese el email"); }

        }
    }
}
