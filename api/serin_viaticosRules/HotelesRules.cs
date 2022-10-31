using serin_viaticosRules.Entities;
using serin_viaticosRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serin_viaticosRules
{
    public class HotelesRules
    {
        public void Agregar(string Nombre,int IdUbicacion,string Telefono, string Email, string Direccion)
        {
         //FALTARIA VALIDAR QUE LA UBICAICON EXISTA Y EL 
            Validar(Nombre, IdUbicacion, Direccion);
            Hoteles pf = new Hoteles();
            
            pf.Nombre = Nombre;
            pf.Nombre= Nombre;
            pf.IdUbicacion= IdUbicacion;
            pf.Telefono= Telefono;
            pf.Email= Email;
            pf.Direccion= Direccion;

            HotelesMapper.Instance().Insert(pf);
        }

        
        public void Modificar(int IdHotel,string Nombre, int IdUbicacion, string Telefono, string Email, string Direccion)        
        {
            //me fijo si el id existe y si es tiene algo escrito

            //Validar(Nombre);
            Hoteles pf = HotelesMapper.Instance().GetOne(IdHotel);
            if (pf == null)
            {
                throw new Exception("No se encuentra el codigo");
            }


            pf.Nombre = Nombre;
            pf.Nombre = Nombre;
            pf.IdUbicacion = IdUbicacion;
            pf.Telefono = Telefono;
            pf.Email = Email;
            pf.Direccion = Direccion;


            HotelesMapper.Instance().Save(pf);

        }
        public void Eliminar(int IdHotel)
        {
            Hoteles pf = HotelesMapper.Instance().GetOne(IdHotel);

            if (pf == null)
            {
                throw new Exception("No se encuentra el Id.");
            }

            HotelesMapper.Instance().Delete(pf);

        }
        
        private void Validar(string Nombre, int IdUbicacion, string Direccion)
        {
            if (string.IsNullOrEmpty(Nombre)){ throw new Exception("Debe ingresar el nombre"); }
            if (IdUbicacion == 0) { throw new Exception("Debe ingresar un codigo de IdUbicacion"); }
            if (string.IsNullOrEmpty(Direccion)) { throw new Exception("Debe ingresar el Direccion"); }
        }
        
    }
}
