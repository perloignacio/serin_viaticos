
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ItinerarioObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace serin_viaticosRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ItinerarioObject : BaseObject, IMappeableItinerarioObject, IUniqueIdentifiable, IEquatable<ItinerarioObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioObject(): base()
        {

			_IdItinerario =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioObject(
			System.Int32 IdItinerario): base()
        {

			_IdItinerario = IdItinerario;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ItinerarioObject(
			System.Int32 IdItinerario,
			System.DateTime Fecha,
			System.Boolean IdaVuelta,
			System.Nullable<System.DateTime> FechaVuelta,
			System.Nullable<System.Decimal> Km): base()
        {

			_IdItinerario = IdItinerario;
			_Fecha = Fecha;
			_IdaVuelta = IdaVuelta;
			_FechaVuelta = FechaVuelta;
			_Km = Km;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdItinerario;
/// <summary>
/// 
/// </summary>
protected System.DateTime _Fecha;
/// <summary>
/// 
/// </summary>
protected System.Boolean _IdaVuelta;
/// <summary>
///
/// </summary>
protected System.Nullable<System.DateTime> _FechaVuelta;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Decimal> _Km;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdItinerario
        {
            get
            {
                return _IdItinerario;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            
            set
            {
                base.PropertyModified();
                _Fecha = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean IdaVuelta
        {
            get
            {
                return _IdaVuelta;
            }
            
            set
            {
                base.PropertyModified();
                _IdaVuelta = value;
                
            }
            
        }
        
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.DateTime> FechaVuelta
        {
            get
            {
                return _FechaVuelta;
            }
            
            set
            {
                base.PropertyModified();
                _FechaVuelta = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Decimal> Km
        {
            get
            {
                return _Km;
            }
            
            set
            {
                base.PropertyModified();
                _Km = value;                
                
            }
            
        }
                
        #endregion

        
            
                
        /// <summary>
        /// 
        /// </summary>
        protected override void SetOriginalValue()
        {
            base._OriginalValue = (IObject) this.MemberwiseClone();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ItinerarioObject newObject;
            ItinerarioObject newOriginalValue;

            newObject = (ItinerarioObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ItinerarioObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ItinerarioObject OriginalValue()
        {
            return (ItinerarioObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableItinerarioObject.HydrateFields(
			System.Int32 IdItinerario,
			System.DateTime Fecha,
			System.Boolean IdaVuelta,
			System.Nullable<System.DateTime> FechaVuelta,
			System.Nullable<System.Decimal> Km)
        {
        _IdItinerario = IdItinerario;
_Fecha = Fecha;
_IdaVuelta = IdaVuelta;
_FechaVuelta = FechaVuelta;
_Km = Km;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableItinerarioObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[5];
            _myArray[0] = _IdItinerario;
_myArray[1] = _Fecha;
_myArray[2] = _IdaVuelta;
if (_FechaVuelta.HasValue) _myArray[3] = _FechaVuelta.Value;
if (_Km.HasValue) _myArray[4] = _Km.Value;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableItinerarioObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[5];
            _myArray[0] = _IdItinerario;
_myArray[1] = _Fecha;
_myArray[2] = _IdaVuelta;
if (_FechaVuelta.HasValue) _myArray[3] = _FechaVuelta.Value;
if (_Km.HasValue) _myArray[4] = _Km.Value;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableItinerarioObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdItinerario;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableItinerarioObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdItinerario = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ItinerarioObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdItinerario};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ItinerarioObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableItinerarioObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdItinerario, 
			System.DateTime Fecha, 
			System.Boolean IdaVuelta, 
			System.Nullable<System.DateTime> FechaVuelta, 
			System.Nullable<System.Decimal> Km);

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForInsert();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForUpdate();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForDelete();

        /// <summary>
        /// 
        /// </summary>
        void UpdateObjectFromOutputParams(object[] parameters);
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class ItinerarioObjectList : ObjectList<ItinerarioObject>
    {
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ItinerarioObjectListView
        : ObjectListView<Objects.ItinerarioObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ItinerarioObjectListView(Objects.ItinerarioObjectList list): base(list)
        {
        }
    }
}


