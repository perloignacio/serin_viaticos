
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 27/09/2022 - 8:10
// This is a partial class file. The other one is PerfilesUsuariosEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace serin_viaticosRules.Entities
{
    /// <summary>
    /// This class represents the PerfilesUsuarios entity.
    /// </summary>
    [Serializable]
    public partial class PerfilesUsuarios
        // : IValidable
    {
        // /// <summary>
        // /// When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        // /// </summary>
        // public void Validate()
        // {
        //     //Example:
        //     if (string.IsNullOrEmpty(this.Name)) throw new RuleValidationException("Name can't be null");
        // }
    }

    /// <summary>
    /// This class represents a collection of PerfilesUsuarios entity.
    /// </summary>
    public partial class PerfilesUsuariosList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<PerfilesUsuarios, PerfilesUsuariosList> Exporter = new ObjectListHelper<PerfilesUsuarios, PerfilesUsuariosList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of PerfilesUsuarios entities.
    /// </summary>
    public partial class PerfilesUsuariosListView
    {
    }
}


