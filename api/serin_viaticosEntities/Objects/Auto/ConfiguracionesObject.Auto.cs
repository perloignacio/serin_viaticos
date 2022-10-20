
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ConfiguracionesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace serin_viaticosRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ConfiguracionesObject : BaseObject, IMappeableConfiguracionesObject, IUniqueIdentifiable, IEquatable<ConfiguracionesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ConfiguracionesObject(): base()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        public ConfiguracionesObject(
			System.String Clave): base()
        {

			_Clave = Clave;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ConfiguracionesObject(
			System.String Clave,
			System.String Valor): base()
        {

			_Clave = Clave;
			_Valor = Valor;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.String _Clave;
/// <summary>
/// 
/// </summary>
protected System.String _Valor;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Clave
        {
            get
            {
                return _Clave;
            }
            
            set
            {
                base.PropertyModified();
                _Clave = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Valor
        {
            get
            {
                return _Valor;
            }
            
            set
            {
                base.PropertyModified();
                _Valor = value;
                
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
            ConfiguracionesObject newObject;
            ConfiguracionesObject newOriginalValue;

            newObject = (ConfiguracionesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ConfiguracionesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ConfiguracionesObject OriginalValue()
        {
            return (ConfiguracionesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableConfiguracionesObject.HydrateFields(
			System.String Clave,
			System.String Valor)
        {
        _Clave = Clave;
_Valor = Valor;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableConfiguracionesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[2];
            _myArray[0] = _Clave;
_myArray[1] = _Valor;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableConfiguracionesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[3];
            _myArray[0] = _Clave;
_myArray[1] = _Valor;
_myArray[2] = this.OriginalValue()._Clave;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableConfiguracionesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _Clave;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableConfiguracionesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            
        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ConfiguracionesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.Clave};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ConfiguracionesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableConfiguracionesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.String Clave, 
			System.String Valor);

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
    public partial class ConfiguracionesObjectList : ObjectList<ConfiguracionesObject>
    {
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ConfiguracionesObjectListView
        : ObjectListView<Objects.ConfiguracionesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ConfiguracionesObjectListView(Objects.ConfiguracionesObjectList list): base(list)
        {
        }
    }
}

