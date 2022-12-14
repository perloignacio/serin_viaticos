
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is SolicitudesCategoriasGateway.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using serin_viaticosRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Web;




namespace serin_viaticosRules.Gateways
{

    public partial class SolicitudesCategoriasGateway : BaseGateway<SolicitudesCategoriasObject, SolicitudesCategoriasObjectList>, IGenericGateway
    {

        #region "Singleton"

        static SolicitudesCategoriasGateway _instance;

        private SolicitudesCategoriasGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static SolicitudesCategoriasGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new SolicitudesCategoriasGateway();
                else {
                    SolicitudesCategoriasGateway inst = HttpContext.Current.Items["serin_viaticosRules.SolicitudesCategoriasGatewaySingleton"] as SolicitudesCategoriasGateway;
                    if (inst == null) {
                        inst = new SolicitudesCategoriasGateway();
                        HttpContext.Current.Items.Add("serin_viaticosRules.SolicitudesCategoriasGatewaySingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }

        #endregion

        /// <summary>
        /// Return the mapped table name
        /// </summary>
        protected override string TableName
        {
            get { return "SolicitudesCategorias"; }
        }

        protected override string RuleName
        {
            get {return typeof(SolicitudesCategoriasGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, SolicitudesCategoriasObject entity)
        {
            
            IMappeableSolicitudesCategoriasObject SolicitudesCategorias = (IMappeableSolicitudesCategoriasObject)entity;
            SolicitudesCategorias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2),
reader.GetString(3));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(SolicitudesCategoriasObject entity)
        {

            IMappeableSolicitudesCategoriasObject SolicitudesCategorias = (IMappeableSolicitudesCategoriasObject)entity;
            return SolicitudesCategorias.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(SolicitudesCategoriasObject entity)
        {

            IMappeableSolicitudesCategoriasObject SolicitudesCategorias = (IMappeableSolicitudesCategoriasObject)entity;
            return SolicitudesCategorias.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(SolicitudesCategoriasObject entity)
        {

            IMappeableSolicitudesCategoriasObject SolicitudesCategorias = (IMappeableSolicitudesCategoriasObject)entity;
            return SolicitudesCategorias.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(SolicitudesCategoriasObject row, object[] parameters)
        {
            ((IMappeableSolicitudesCategoriasObject) row).UpdateObjectFromOutputParams(parameters);
            ((IObject)row).State = ObjectState.Restored;
        }

        /// <summary>
        /// StoredProceduresPrefix, for example: coop_
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        /// <summary>
        /// Get a SolicitudesCategoriasObject by execute a SQL Query Text
        /// </summary>
        public SolicitudesCategoriasObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a SolicitudesCategoriasObjectList by execute a SQL Query Text
        /// </summary>
        public SolicitudesCategoriasObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a SolicitudesCategoriasObject by calling a Stored Procedure
        /// </summary>
        public SolicitudesCategoriasObject GetOne(System.Int32 IdSolicitudCategoria)
        {
            return base.GetOne(new SolicitudesCategoriasObject(IdSolicitudCategoria));
        }


        // GetBy Objects and Params
            


        

        

        /// <summary>
        /// Delete SolicitudesCategorias
        /// </summary>
        public void Delete(System.Int32 IdSolicitudCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesCategorias_Delete", IdSolicitudCategoria);
        }

        /// <summary>
        /// Delete SolicitudesCategorias
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdSolicitudCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesCategorias_Delete", IdSolicitudCategoria);
        }

            

        


        //Database Queries 
        



        #region IGenericGateway

        object IGenericGateway.GetOne(IUniqueIdentifiable identifier)
        {
            return base.GetOne(identifier);
        }

        object IGenericGateway.GetAll()
        {
            return base.GetAll();
        }

        object IGenericGateway.GetByParent(IUniqueIdentifiable parentEntity)
        {
            return base.GetByParent(parentEntity);
        }

        #endregion


    }

}








