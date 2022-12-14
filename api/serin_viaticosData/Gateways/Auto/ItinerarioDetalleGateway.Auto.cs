
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ItinerarioDetalleGateway.cs
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

    public partial class ItinerarioDetalleGateway : BaseGateway<ItinerarioDetalleObject, ItinerarioDetalleObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ItinerarioDetalleGateway _instance;

        private ItinerarioDetalleGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ItinerarioDetalleGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ItinerarioDetalleGateway();
                else {
                    ItinerarioDetalleGateway inst = HttpContext.Current.Items["serin_viaticosRules.ItinerarioDetalleGatewaySingleton"] as ItinerarioDetalleGateway;
                    if (inst == null) {
                        inst = new ItinerarioDetalleGateway();
                        HttpContext.Current.Items.Add("serin_viaticosRules.ItinerarioDetalleGatewaySingleton", inst);
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
            get { return "ItinerarioDetalle"; }
        }

        protected override string RuleName
        {
            get {return typeof(ItinerarioDetalleGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ItinerarioDetalleObject entity)
        {
            
            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            ItinerarioDetalle.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ItinerarioDetalleObject entity)
        {

            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            return ItinerarioDetalle.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ItinerarioDetalleObject entity)
        {

            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            return ItinerarioDetalle.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ItinerarioDetalleObject entity)
        {

            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            return ItinerarioDetalle.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ItinerarioDetalleObject row, object[] parameters)
        {
            ((IMappeableItinerarioDetalleObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ItinerarioDetalleObject by execute a SQL Query Text
        /// </summary>
        public ItinerarioDetalleObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by execute a SQL Query Text
        /// </summary>
        public ItinerarioDetalleObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ItinerarioDetalleObject by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObject GetOne(System.Int32 IdItinerarioDetalle)
        {
            return base.GetOne(new ItinerarioDetalleObject(IdItinerarioDetalle));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByItinerario(DbTransaction transaction,System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByUbicaciones(DbTransaction transaction,System.Int32 IdParada)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", IdParada);
        }

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByUbicaciones(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", Ubicaciones.Identifier());
        }

    

        

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByItinerario(System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByItinerario(IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByUbicaciones(System.Int32 IdParada)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", IdParada);
        }

        /// <summary>
        /// Get a ItinerarioDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ItinerarioDetalleObjectList GetByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", Ubicaciones.Identifier());
        }

    

        /// <summary>
        /// Delete ItinerarioDetalle
        /// </summary>
        public void Delete(System.Int32 IdItinerarioDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_Delete", IdItinerarioDetalle);
        }

        /// <summary>
        /// Delete ItinerarioDetalle
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdItinerarioDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_Delete", IdItinerarioDetalle);
        }

            

        

        /// <summary>
        /// Delete ItinerarioDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(System.Int32 IdItinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", IdItinerario);
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(DbTransaction transaction, System.Int32 IdItinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", IdItinerario);
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(IUniqueIdentifiable Itinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", Itinerario.Identifier());
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", Itinerario.Identifier());
        }


    

        /// <summary>
        /// Delete ItinerarioDetalle by Ubicaciones
        /// </summary>
        public void DeleteByUbicaciones(System.Int32 IdParada)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", IdParada);
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Ubicaciones
        /// </summary>
        public void DeleteByUbicaciones(DbTransaction transaction, System.Int32 IdParada)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", IdParada);
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Ubicaciones
        /// </summary>
        public void DeleteByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", Ubicaciones.Identifier());
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Ubicaciones
        /// </summary>
        public void DeleteByUbicaciones(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", Ubicaciones.Identifier());
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








