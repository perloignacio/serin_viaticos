
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ReservasAereosGateway.cs
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

    public partial class ReservasAereosGateway : BaseGateway<ReservasAereosObject, ReservasAereosObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ReservasAereosGateway _instance;

        private ReservasAereosGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ReservasAereosGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ReservasAereosGateway();
                else {
                    ReservasAereosGateway inst = HttpContext.Current.Items["serin_viaticosRules.ReservasAereosGatewaySingleton"] as ReservasAereosGateway;
                    if (inst == null) {
                        inst = new ReservasAereosGateway();
                        HttpContext.Current.Items.Add("serin_viaticosRules.ReservasAereosGatewaySingleton", inst);
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
            get { return "ReservasAereos"; }
        }

        protected override string RuleName
        {
            get {return typeof(ReservasAereosGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ReservasAereosObject entity)
        {
            
            IMappeableReservasAereosObject ReservasAereos = (IMappeableReservasAereosObject)entity;
            ReservasAereos.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetInt32(3),
reader.GetDateTime(4),
reader.GetBoolean(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(6),
(reader.IsDBNull(7)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(7));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ReservasAereosObject entity)
        {

            IMappeableReservasAereosObject ReservasAereos = (IMappeableReservasAereosObject)entity;
            return ReservasAereos.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ReservasAereosObject entity)
        {

            IMappeableReservasAereosObject ReservasAereos = (IMappeableReservasAereosObject)entity;
            return ReservasAereos.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ReservasAereosObject entity)
        {

            IMappeableReservasAereosObject ReservasAereos = (IMappeableReservasAereosObject)entity;
            return ReservasAereos.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ReservasAereosObject row, object[] parameters)
        {
            ((IMappeableReservasAereosObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ReservasAereosObject by execute a SQL Query Text
        /// </summary>
        public ReservasAereosObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ReservasAereosObjectList by execute a SQL Query Text
        /// </summary>
        public ReservasAereosObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ReservasAereosObject by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObject GetOne(System.Int32 IdReservaAereo)
        {
            return base.GetOne(new ReservasAereosObject(IdReservaAereo));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesDestino(DbTransaction transaction,System.Int32 IdDestino)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesDestino", IdDestino);
        }

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesDestino(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesDestino", Ubicaciones.Identifier());
        }

    

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesOrigen(DbTransaction transaction,System.Int32 IdOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesOrigen", IdOrigen);
        }

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesOrigen(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesOrigen", Ubicaciones.Identifier());
        }

    

        

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesDestino(System.Int32 IdDestino)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesDestino", IdDestino);
        }

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesDestino(IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesDestino", Ubicaciones.Identifier());
        }

    

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesOrigen(System.Int32 IdOrigen)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesOrigen", IdOrigen);
        }

        /// <summary>
        /// Get a ReservasAereosObjectList by calling a Stored Procedure
        /// </summary>
        public ReservasAereosObjectList GetByUbicacionesOrigen(IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_GetByUbicacionesOrigen", Ubicaciones.Identifier());
        }

    

        /// <summary>
        /// Delete ReservasAereos
        /// </summary>
        public void Delete(System.Int32 IdReservaAereo)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_Delete", IdReservaAereo);
        }

        /// <summary>
        /// Delete ReservasAereos
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdReservaAereo)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_Delete", IdReservaAereo);
        }

            

        

        /// <summary>
        /// Delete ReservasAereos by UbicacionesDestino
        /// </summary>
        public void DeleteByUbicacionesDestino(System.Int32 IdDestino)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesDestino", IdDestino);
        }

        /// <summary>
        /// Delete ReservasAereos by UbicacionesDestino
        /// </summary>
        public void DeleteByUbicacionesDestino(DbTransaction transaction, System.Int32 IdDestino)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesDestino", IdDestino);
        }

        /// <summary>
        /// Delete ReservasAereos by UbicacionesDestino
        /// </summary>
        public void DeleteByUbicacionesDestino(IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesDestino", Ubicaciones.Identifier());
        }

        /// <summary>
        /// Delete ReservasAereos by UbicacionesDestino
        /// </summary>
        public void DeleteByUbicacionesDestino(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesDestino", Ubicaciones.Identifier());
        }


    

        /// <summary>
        /// Delete ReservasAereos by UbicacionesOrigen
        /// </summary>
        public void DeleteByUbicacionesOrigen(System.Int32 IdOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesOrigen", IdOrigen);
        }

        /// <summary>
        /// Delete ReservasAereos by UbicacionesOrigen
        /// </summary>
        public void DeleteByUbicacionesOrigen(DbTransaction transaction, System.Int32 IdOrigen)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesOrigen", IdOrigen);
        }

        /// <summary>
        /// Delete ReservasAereos by UbicacionesOrigen
        /// </summary>
        public void DeleteByUbicacionesOrigen(IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesOrigen", Ubicaciones.Identifier());
        }

        /// <summary>
        /// Delete ReservasAereos by UbicacionesOrigen
        /// </summary>
        public void DeleteByUbicacionesOrigen(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ReservasAereos_DeleteByUbicacionesOrigen", Ubicaciones.Identifier());
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








