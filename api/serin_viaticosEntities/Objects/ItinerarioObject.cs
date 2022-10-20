
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 20/10/2022 - 11:24
// This is a partial class file. The other one is ItinerarioObject.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core;
using Cooperator.Framework.Core.Exceptions;

namespace serin_viaticosRules.Objects
{
    /// <summary>
    /// This class represents a Object of Itinerario table.
    /// </summary>
    [Serializable]
    public partial class ItinerarioObject
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
    /// This class represents a record set of Itinerario table.
    /// </summary>
    public partial class ItinerarioObjectList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         // public override System.Data.DataSet ToDataSet()
         // {
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<ItinerarioObject, ItinerarioObjectList> Exporter = new ObjectListHelper<ItinerarioObject, ItinerarioObjectList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         // }
    }
}

namespace serin_viaticosRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of ItinerarioObjects.
    /// </summary>
    public partial class ItinerarioObjectListView
    {
    }
}


