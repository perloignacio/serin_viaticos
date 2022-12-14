
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is PerfilesUsuariosEntity.cs
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
    public partial class PerfilesUsuarios : Objects.PerfilesUsuariosObject, IMappeablePerfilesUsuarios, IEquatable<PerfilesUsuarios>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public PerfilesUsuarios()
            :base()
        {
            if (_PerfilesEntity == null) _PerfilesEntity = new Entities.Perfiles();

        }

        /// <summary>
        /// 
        /// </summary>
        public PerfilesUsuarios(
			System.Int32 IdUsuarioPerfil)
            : base()
        {

			_IdUsuarioPerfil = IdUsuarioPerfil;

            if (_PerfilesEntity == null) _PerfilesEntity = new Entities.Perfiles();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public PerfilesUsuarios(
			System.Int32 IdUsuarioPerfil,
			System.Int32 IdUsuario,
			System.Int32 IdPerfil)
            : base()
        {

			_IdUsuarioPerfil = IdUsuarioPerfil;
			_IdUsuario = IdUsuario;
			_IdPerfil = IdPerfil;

            if (_PerfilesEntity == null) _PerfilesEntity = new Entities.Perfiles();

            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Entities.Perfiles _PerfilesEntity;

        #endregion

        #region "Properties"
        
bool _PerfilesEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.Perfiles PerfilesEntity
        {
            get
            {
                if (_PerfilesEntity== null  && ! _PerfilesEntityFetched ) {
_PerfilesEntityFetched = true;
Entities.Perfiles _PerfilesEntityTemp = new Entities.Perfiles(this.IdPerfil); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.Perfiles));
 _PerfilesEntity = lazyProvider.GetEntity(typeof(Entities.Perfiles), _PerfilesEntityTemp) as Entities.Perfiles;
}

                return _PerfilesEntity;
            }
            set
            {
                base.PropertyModified();
                _PerfilesEntity = value;
                if (value != null) {
   _IdPerfil = value.IdPerfil;

} else {
   _IdPerfil = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new PerfilesUsuarios OriginalValue()
        {
            return (PerfilesUsuarios)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            PerfilesUsuarios newObject;            
            

            newObject = (PerfilesUsuarios)this.MemberwiseClone();
            // Entities
                         
            if (this._PerfilesEntity != null)
            {
                newObject._PerfilesEntity = (Entities.Perfiles)((ICloneable)this._PerfilesEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            PerfilesUsuarios newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (PerfilesUsuarios)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._PerfilesEntity != null)
                {
                    newOriginalValue._PerfilesEntity = (Entities.Perfiles)((ICloneable)this.OriginalValue()._PerfilesEntity).Clone();
                }
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeablePerfilesUsuarios.CompleteEntity(Entities.Perfiles PerfilesEntity)
        {
        _PerfilesEntity = PerfilesEntity;
        }
        
        bool IMappeablePerfilesUsuarios.IsPerfilesEntityNull()
        {
            return (_PerfilesEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeablePerfilesUsuarios.SetFKValuesForChilds(PerfilesUsuarios entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PerfilesUsuarios other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeablePerfilesUsuarios
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.Perfiles PerfilesEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsPerfilesEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(PerfilesUsuarios entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class PerfilesUsuariosList : ObjectList<PerfilesUsuarios>
    {
    }
}
namespace serin_viaticosRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class PerfilesUsuariosListView
        : ObjectListView<Entities.PerfilesUsuarios>
    {
        /// <summary>
        /// 
        /// </summary>
        public PerfilesUsuariosListView(Entities.PerfilesUsuariosList list): base(list)
        {
        }
    }
}


