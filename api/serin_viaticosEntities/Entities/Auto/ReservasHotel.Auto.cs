
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ReservasHotelEntity.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using serin_viaticosRules.Objects;



using Cooperator.Framework.Core;
using Cooperator.Framework.Core.LazyLoad;
using System;

namespace serin_viaticosRules.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ReservasHotel : Objects.ReservasHotelObject, IMappeableReservasHotel, IEquatable<ReservasHotel>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ReservasHotel()
            :base()
        {
            if (_HotelesEntity == null) _HotelesEntity = new Entities.Hoteles();
if (_UbicacionesEntity == null) _UbicacionesEntity = new Entities.Ubicaciones();

        }

        /// <summary>
        /// 
        /// </summary>
        public ReservasHotel(
			System.Int32 IdReservaHotel)
            : base()
        {

			_IdReservaHotel = IdReservaHotel;

            if (_HotelesEntity == null) _HotelesEntity = new Entities.Hoteles();
if (_UbicacionesEntity == null) _UbicacionesEntity = new Entities.Ubicaciones();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ReservasHotel(
			System.Int32 IdReservaHotel,
			System.Int32 IdDestino,
			System.Int32 CantHabitaciones,
			System.Int32 CantPasajeros,
			System.Int32 IdHotel,
			System.String CodigoReserva,
			System.Nullable<System.Decimal> Precio,
			System.DateTime Checkin,
			System.DateTime Checkout)
            : base()
        {

			_IdReservaHotel = IdReservaHotel;
			_IdDestino = IdDestino;
			_CantHabitaciones = CantHabitaciones;
			_CantPasajeros = CantPasajeros;
			_IdHotel = IdHotel;
			_CodigoReserva = CodigoReserva;
			_Precio = Precio;
			_Checkin = Checkin;
			_Checkout = Checkout;

            if (_HotelesEntity == null) _HotelesEntity = new Entities.Hoteles();
if (_UbicacionesEntity == null) _UbicacionesEntity = new Entities.Ubicaciones();

            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Entities.Hoteles _HotelesEntity;
/// <summary>
/// 
/// </summary>
protected Entities.Ubicaciones _UbicacionesEntity;

        #endregion

        #region "Properties"
        
bool _HotelesEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.Hoteles HotelesEntity
        {
            get
            {
                if (_HotelesEntity== null  && ! _HotelesEntityFetched ) {
_HotelesEntityFetched = true;
Entities.Hoteles _HotelesEntityTemp = new Entities.Hoteles(this.IdHotel); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.Hoteles));
 _HotelesEntity = lazyProvider.GetEntity(typeof(Entities.Hoteles), _HotelesEntityTemp) as Entities.Hoteles;
}

                return _HotelesEntity;
            }
            set
            {
                base.PropertyModified();
                _HotelesEntity = value;
                if (value != null) {
   _IdHotel = value.IdHotel;

} else {
   _IdHotel = System.Int32.MinValue;

}

            }
        }
        
bool _UbicacionesEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.Ubicaciones UbicacionesEntity
        {
            get
            {
                if (_UbicacionesEntity== null  && ! _UbicacionesEntityFetched ) {
_UbicacionesEntityFetched = true;
Entities.Ubicaciones _UbicacionesEntityTemp = new Entities.Ubicaciones(this.IdDestino); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.Ubicaciones));
 _UbicacionesEntity = lazyProvider.GetEntity(typeof(Entities.Ubicaciones), _UbicacionesEntityTemp) as Entities.Ubicaciones;
}

                return _UbicacionesEntity;
            }
            set
            {
                base.PropertyModified();
                _UbicacionesEntity = value;
                if (value != null) {
   _IdDestino = value.IdUbicacion;

} else {
   _IdDestino = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ReservasHotel OriginalValue()
        {
            return (ReservasHotel)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ReservasHotel newObject;            
            

            newObject = (ReservasHotel)this.MemberwiseClone();
            // Entities
                         
            if (this._HotelesEntity != null)
            {
                newObject._HotelesEntity = (Entities.Hoteles)((ICloneable)this._HotelesEntity).Clone();
            }
                         
            if (this._UbicacionesEntity != null)
            {
                newObject._UbicacionesEntity = (Entities.Ubicaciones)((ICloneable)this._UbicacionesEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            ReservasHotel newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ReservasHotel)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._HotelesEntity != null)
                {
                    newOriginalValue._HotelesEntity = (Entities.Hoteles)((ICloneable)this.OriginalValue()._HotelesEntity).Clone();
                }
                             
                if (this.OriginalValue()._UbicacionesEntity != null)
                {
                    newOriginalValue._UbicacionesEntity = (Entities.Ubicaciones)((ICloneable)this.OriginalValue()._UbicacionesEntity).Clone();
                }
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableReservasHotel.CompleteEntity(Entities.Hoteles HotelesEntity, Entities.Ubicaciones UbicacionesEntity)
        {
        _HotelesEntity = HotelesEntity;
_UbicacionesEntity = UbicacionesEntity;
        }
        
        bool IMappeableReservasHotel.IsHotelesEntityNull()
        {
            return (_HotelesEntity == null);
        }
        
        bool IMappeableReservasHotel.IsUbicacionesEntityNull()
        {
            return (_UbicacionesEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableReservasHotel.SetFKValuesForChilds(ReservasHotel entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ReservasHotel other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableReservasHotel
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.Hoteles HotelesEntity, Entities.Ubicaciones UbicacionesEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsHotelesEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsUbicacionesEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ReservasHotel entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ReservasHotelList : ObjectList<ReservasHotel>
    {
    }
}
namespace serin_viaticosRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ReservasHotelListView
        : ObjectListView<Entities.ReservasHotel>
    {
        /// <summary>
        /// 
        /// </summary>
        public ReservasHotelListView(Entities.ReservasHotelList list): base(list)
        {
        }
    }
}


