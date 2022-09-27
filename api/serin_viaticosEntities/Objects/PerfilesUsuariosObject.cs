
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 27/09/2022 - 8:10
// This is a partial class file. The other one is PerfilesUsuariosObject.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core;
using Cooperator.Framework.Core.Exceptions;

namespace serin_viaticosRules.Objects
{
    /// <summary>
    /// This class represents a Object of PerfilesUsuarios table.
    /// </summary>
    [Serializable]
    public partial class PerfilesUsuariosObject
        // : IValidable
    {

        /// <summary>
        /// Called from class constructor.
        /// </summary>
        protected override void Initialize()
        {
        }

        // /// <summary>
        // /// Called after parameterized constructor. 
        // /// </summary>
        // protected override void Initialized()
        // {       
        // //Warnging: This method is only called by parameterized contructors.
        // }

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
    /// This class represents a record set of PerfilesUsuarios table.
    /// </summary>
    public partial class PerfilesUsuariosObjectList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         // public override System.Data.DataSet ToDataSet()
         // {
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<PerfilesUsuariosObject, PerfilesUsuariosObjectList> Exporter = new ObjectListHelper<PerfilesUsuariosObject, PerfilesUsuariosObjectList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         // }
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of PerfilesUsuariosObjects.
    /// </summary>
    public partial class PerfilesUsuariosObjectListView
    {
    }
}


