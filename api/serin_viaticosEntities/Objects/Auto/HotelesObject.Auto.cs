
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is HotelesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace serin_viaticosRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HotelesObject : BaseObject, IMappeableHotelesObject, IUniqueIdentifiable, IEquatable<HotelesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public HotelesObject(): base()
        {

			_IdHotel =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public HotelesObject(
			System.Int32 IdHotel): base()
        {

			_IdHotel = IdHotel;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public HotelesObject(
			System.Int32 IdHotel,
			System.String Nombre,
			System.Int32 IdUbicacion,
			System.String Telefono,
			System.String Email,
			System.String Direccion): base()
        {

			_IdHotel = IdHotel;
			_Nombre = Nombre;
			_IdUbicacion = IdUbicacion;
			_Telefono = Telefono;
			_Email = Email;
			_Direccion = Direccion;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdHotel;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdUbicacion;
/// <summary>
/// 
/// </summary>
protected System.String _Telefono;
/// <summary>
/// 
/// </summary>
protected System.String _Email;
/// <summary>
/// 
/// </summary>
protected System.String _Direccion;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdHotel
        {
            get
            {
                return _IdHotel;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            
            set
            {
                base.PropertyModified();
                _Nombre = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdUbicacion
        {
            get
            {
                return _IdUbicacion;
            }
            
            set
            {
                base.PropertyModified();
                _IdUbicacion = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Telefono
        {
            get
            {
                return _Telefono;
            }
            
            set
            {
                base.PropertyModified();
                _Telefono = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Email
        {
            get
            {
                return _Email;
            }
            
            set
            {
                base.PropertyModified();
                _Email = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Direccion
        {
            get
            {
                return _Direccion;
            }
            
            set
            {
                base.PropertyModified();
                _Direccion = value;
                
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
            HotelesObject newObject;
            HotelesObject newOriginalValue;

            newObject = (HotelesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (HotelesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new HotelesObject OriginalValue()
        {
            return (HotelesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableHotelesObject.HydrateFields(
			System.Int32 IdHotel,
			System.String Nombre,
			System.Int32 IdUbicacion,
			System.String Telefono,
			System.String Email,
			System.String Direccion)
        {
        _IdHotel = IdHotel;
_Nombre = Nombre;
_IdUbicacion = IdUbicacion;
_Telefono = Telefono;
_Email = Email;
_Direccion = Direccion;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableHotelesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[6];
            _myArray[0] = _IdHotel;
_myArray[1] = _Nombre;
_myArray[2] = _IdUbicacion;
if (!System.String.IsNullOrEmpty(_Telefono)) _myArray[3] = _Telefono;
if (!System.String.IsNullOrEmpty(_Email)) _myArray[4] = _Email;
_myArray[5] = _Direccion;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableHotelesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[6];
            _myArray[0] = _IdHotel;
_myArray[1] = _Nombre;
_myArray[2] = _IdUbicacion;
if (!System.String.IsNullOrEmpty(_Telefono)) _myArray[3] = _Telefono;
if (!System.String.IsNullOrEmpty(_Email)) _myArray[4] = _Email;
_myArray[5] = _Direccion;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableHotelesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdHotel;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableHotelesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdHotel = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            HotelesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdHotel};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(HotelesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableHotelesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdHotel, 
			System.String Nombre, 
			System.Int32 IdUbicacion, 
			System.String Telefono, 
			System.String Email, 
			System.String Direccion);

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
    public partial class HotelesObjectList : ObjectList<HotelesObject>
    {
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HotelesObjectListView
        : ObjectListView<Objects.HotelesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public HotelesObjectListView(Objects.HotelesObjectList list): base(list)
        {
        }
    }
}


