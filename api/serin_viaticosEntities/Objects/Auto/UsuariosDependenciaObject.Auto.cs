
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is UsuariosDependenciaObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace serin_viaticosRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UsuariosDependenciaObject : BaseObject, IMappeableUsuariosDependenciaObject, IUniqueIdentifiable, IEquatable<UsuariosDependenciaObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public UsuariosDependenciaObject(): base()
        {

			_IdUsuarioDependencia =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public UsuariosDependenciaObject(
			System.Int32 IdUsuarioDependencia): base()
        {

			_IdUsuarioDependencia = IdUsuarioDependencia;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public UsuariosDependenciaObject(
			System.Int32 IdUsuarioDependencia,
			System.Int32 IdUsuarioPadre,
			System.Int32 IdUsuarioHijo): base()
        {

			_IdUsuarioDependencia = IdUsuarioDependencia;
			_IdUsuarioPadre = IdUsuarioPadre;
			_IdUsuarioHijo = IdUsuarioHijo;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdUsuarioDependencia;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdUsuarioPadre;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdUsuarioHijo;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdUsuarioDependencia
        {
            get
            {
                return _IdUsuarioDependencia;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdUsuarioPadre
        {
            get
            {
                return _IdUsuarioPadre;
            }
            
            set
            {
                base.PropertyModified();
                _IdUsuarioPadre = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdUsuarioHijo
        {
            get
            {
                return _IdUsuarioHijo;
            }
            
            set
            {
                base.PropertyModified();
                _IdUsuarioHijo = value;
                
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
            UsuariosDependenciaObject newObject;
            UsuariosDependenciaObject newOriginalValue;

            newObject = (UsuariosDependenciaObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (UsuariosDependenciaObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new UsuariosDependenciaObject OriginalValue()
        {
            return (UsuariosDependenciaObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableUsuariosDependenciaObject.HydrateFields(
			System.Int32 IdUsuarioDependencia,
			System.Int32 IdUsuarioPadre,
			System.Int32 IdUsuarioHijo)
        {
        _IdUsuarioDependencia = IdUsuarioDependencia;
_IdUsuarioPadre = IdUsuarioPadre;
_IdUsuarioHijo = IdUsuarioHijo;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableUsuariosDependenciaObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdUsuarioDependencia;
_myArray[1] = _IdUsuarioPadre;
_myArray[2] = _IdUsuarioHijo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableUsuariosDependenciaObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[3];
            _myArray[0] = _IdUsuarioDependencia;
_myArray[1] = _IdUsuarioPadre;
_myArray[2] = _IdUsuarioHijo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableUsuariosDependenciaObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdUsuarioDependencia;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableUsuariosDependenciaObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdUsuarioDependencia = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            UsuariosDependenciaObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdUsuarioDependencia};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(UsuariosDependenciaObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableUsuariosDependenciaObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdUsuarioDependencia, 
			System.Int32 IdUsuarioPadre, 
			System.Int32 IdUsuarioHijo);

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
    public partial class UsuariosDependenciaObjectList : ObjectList<UsuariosDependenciaObject>
    {
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UsuariosDependenciaObjectListView
        : ObjectListView<Objects.UsuariosDependenciaObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public UsuariosDependenciaObjectListView(Objects.UsuariosDependenciaObjectList list): base(list)
        {
        }
    }
}


