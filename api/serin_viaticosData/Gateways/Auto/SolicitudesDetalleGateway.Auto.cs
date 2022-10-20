
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is SolicitudesDetalleGateway.cs
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

    public partial class SolicitudesDetalleGateway : BaseGateway<SolicitudesDetalleObject, SolicitudesDetalleObjectList>, IGenericGateway
    {

        #region "Singleton"

        static SolicitudesDetalleGateway _instance;

        private SolicitudesDetalleGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static SolicitudesDetalleGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new SolicitudesDetalleGateway();
                else {
                    SolicitudesDetalleGateway inst = HttpContext.Current.Items["serin_viaticosRules.SolicitudesDetalleGatewaySingleton"] as SolicitudesDetalleGateway;
                    if (inst == null) {
                        inst = new SolicitudesDetalleGateway();
                        HttpContext.Current.Items.Add("serin_viaticosRules.SolicitudesDetalleGatewaySingleton", inst);
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
            get { return "SolicitudesDetalle"; }
        }

        protected override string RuleName
        {
            get {return typeof(SolicitudesDetalleGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, SolicitudesDetalleObject entity)
        {
            
            IMappeableSolicitudesDetalleObject SolicitudesDetalle = (IMappeableSolicitudesDetalleObject)entity;
            SolicitudesDetalle.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
(reader.IsDBNull(3)) ? new System.Nullable<System.Int32>() : reader.GetInt32(3),
(reader.IsDBNull(4)) ? new System.Nullable<System.Int32>() : reader.GetInt32(4),
(reader.IsDBNull(5)) ? new System.Nullable<System.Int32>() : reader.GetInt32(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.Int32>() : reader.GetInt32(6),
(reader.IsDBNull(7)) ? "" : reader.GetString(7));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(SolicitudesDetalleObject entity)
        {

            IMappeableSolicitudesDetalleObject SolicitudesDetalle = (IMappeableSolicitudesDetalleObject)entity;
            return SolicitudesDetalle.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(SolicitudesDetalleObject entity)
        {

            IMappeableSolicitudesDetalleObject SolicitudesDetalle = (IMappeableSolicitudesDetalleObject)entity;
            return SolicitudesDetalle.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(SolicitudesDetalleObject entity)
        {

            IMappeableSolicitudesDetalleObject SolicitudesDetalle = (IMappeableSolicitudesDetalleObject)entity;
            return SolicitudesDetalle.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(SolicitudesDetalleObject row, object[] parameters)
        {
            ((IMappeableSolicitudesDetalleObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a SolicitudesDetalleObject by execute a SQL Query Text
        /// </summary>
        public SolicitudesDetalleObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by execute a SQL Query Text
        /// </summary>
        public SolicitudesDetalleObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a SolicitudesDetalleObject by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObject GetOne(System.Int32 IdSolicitudDetalle)
        {
            return base.GetOne(new SolicitudesDetalleObject(IdSolicitudDetalle));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByItinerario(DbTransaction transaction,System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAereos(DbTransaction transaction,System.Int32 IdReservaAereo)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAereos", IdReservaAereo);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAereos(DbTransaction transaction, IUniqueIdentifiable ReservasAereos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAereos", ReservasAereos.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAlquilerAuto(DbTransaction transaction,System.Int32 IdReservaAlquilerAuto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAlquilerAuto", IdReservaAlquilerAuto);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAlquilerAuto(DbTransaction transaction, IUniqueIdentifiable ReservasAlquilerAuto)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAlquilerAuto", ReservasAlquilerAuto.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasHotel(DbTransaction transaction,System.Int32 IdResevaHotel)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasHotel", IdResevaHotel);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasHotel(DbTransaction transaction, IUniqueIdentifiable ReservasHotel)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasHotel", ReservasHotel.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetBySolicitudesCategorias(DbTransaction transaction,System.Int32 IdSolicitudCategoria)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetBySolicitudesCategorias", IdSolicitudCategoria);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetBySolicitudesCategorias(DbTransaction transaction, IUniqueIdentifiable SolicitudesCategorias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_GetBySolicitudesCategorias", SolicitudesCategorias.Identifier());
        }

    

        

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByItinerario(System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByItinerario(IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAereos(System.Int32 IdReservaAereo)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAereos", IdReservaAereo);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAereos(IUniqueIdentifiable ReservasAereos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAereos", ReservasAereos.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAlquilerAuto(System.Int32 IdReservaAlquilerAuto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAlquilerAuto", IdReservaAlquilerAuto);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasAlquilerAuto(IUniqueIdentifiable ReservasAlquilerAuto)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasAlquilerAuto", ReservasAlquilerAuto.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasHotel(System.Int32 IdResevaHotel)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasHotel", IdResevaHotel);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetByReservasHotel(IUniqueIdentifiable ReservasHotel)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetByReservasHotel", ReservasHotel.Identifier());
        }

    

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetBySolicitudesCategorias(System.Int32 IdSolicitudCategoria)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetBySolicitudesCategorias", IdSolicitudCategoria);
        }

        /// <summary>
        /// Get a SolicitudesDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public SolicitudesDetalleObjectList GetBySolicitudesCategorias(IUniqueIdentifiable SolicitudesCategorias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_GetBySolicitudesCategorias", SolicitudesCategorias.Identifier());
        }

    

        /// <summary>
        /// Delete SolicitudesDetalle
        /// </summary>
        public void Delete(System.Int32 IdSolicitudDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_Delete", IdSolicitudDetalle);
        }

        /// <summary>
        /// Delete SolicitudesDetalle
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdSolicitudDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_Delete", IdSolicitudDetalle);
        }

            

        

        /// <summary>
        /// Delete SolicitudesDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(System.Int32 IdItinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByItinerario", IdItinerario);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(DbTransaction transaction, System.Int32 IdItinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByItinerario", IdItinerario);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(IUniqueIdentifiable Itinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByItinerario", Itinerario.Identifier());
        }

        /// <summary>
        /// Delete SolicitudesDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByItinerario", Itinerario.Identifier());
        }


    

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAereos
        /// </summary>
        public void DeleteByReservasAereos(System.Int32 IdReservaAereo)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAereos", IdReservaAereo);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAereos
        /// </summary>
        public void DeleteByReservasAereos(DbTransaction transaction, System.Int32 IdReservaAereo)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAereos", IdReservaAereo);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAereos
        /// </summary>
        public void DeleteByReservasAereos(IUniqueIdentifiable ReservasAereos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAereos", ReservasAereos.Identifier());
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAereos
        /// </summary>
        public void DeleteByReservasAereos(DbTransaction transaction, IUniqueIdentifiable ReservasAereos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAereos", ReservasAereos.Identifier());
        }


    

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAlquilerAuto
        /// </summary>
        public void DeleteByReservasAlquilerAuto(System.Int32 IdReservaAlquilerAuto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAlquilerAuto", IdReservaAlquilerAuto);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAlquilerAuto
        /// </summary>
        public void DeleteByReservasAlquilerAuto(DbTransaction transaction, System.Int32 IdReservaAlquilerAuto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAlquilerAuto", IdReservaAlquilerAuto);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAlquilerAuto
        /// </summary>
        public void DeleteByReservasAlquilerAuto(IUniqueIdentifiable ReservasAlquilerAuto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAlquilerAuto", ReservasAlquilerAuto.Identifier());
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasAlquilerAuto
        /// </summary>
        public void DeleteByReservasAlquilerAuto(DbTransaction transaction, IUniqueIdentifiable ReservasAlquilerAuto)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasAlquilerAuto", ReservasAlquilerAuto.Identifier());
        }


    

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasHotel
        /// </summary>
        public void DeleteByReservasHotel(System.Int32 IdResevaHotel)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasHotel", IdResevaHotel);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasHotel
        /// </summary>
        public void DeleteByReservasHotel(DbTransaction transaction, System.Int32 IdResevaHotel)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasHotel", IdResevaHotel);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasHotel
        /// </summary>
        public void DeleteByReservasHotel(IUniqueIdentifiable ReservasHotel)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasHotel", ReservasHotel.Identifier());
        }

        /// <summary>
        /// Delete SolicitudesDetalle by ReservasHotel
        /// </summary>
        public void DeleteByReservasHotel(DbTransaction transaction, IUniqueIdentifiable ReservasHotel)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteByReservasHotel", ReservasHotel.Identifier());
        }


    

        /// <summary>
        /// Delete SolicitudesDetalle by SolicitudesCategorias
        /// </summary>
        public void DeleteBySolicitudesCategorias(System.Int32 IdSolicitudCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteBySolicitudesCategorias", IdSolicitudCategoria);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by SolicitudesCategorias
        /// </summary>
        public void DeleteBySolicitudesCategorias(DbTransaction transaction, System.Int32 IdSolicitudCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteBySolicitudesCategorias", IdSolicitudCategoria);
        }

        /// <summary>
        /// Delete SolicitudesDetalle by SolicitudesCategorias
        /// </summary>
        public void DeleteBySolicitudesCategorias(IUniqueIdentifiable SolicitudesCategorias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesDetalle_DeleteBySolicitudesCategorias", SolicitudesCategorias.Identifier());
        }

        /// <summary>
        /// Delete SolicitudesDetalle by SolicitudesCategorias
        /// </summary>
        public void DeleteBySolicitudesCategorias(DbTransaction transaction, IUniqueIdentifiable SolicitudesCategorias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesDetalle_DeleteBySolicitudesCategorias", SolicitudesCategorias.Identifier());
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







