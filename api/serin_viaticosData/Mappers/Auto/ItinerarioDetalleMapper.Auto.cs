
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ItinerarioDetalleMapper.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using serin_viaticosRules.Entities;
using serin_viaticosRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data.Common;
using System.Reflection;
using System.Web;
using System.Data;

namespace serin_viaticosRules.Mappers
{

    
    /// <summary>
    /// 
    /// </summary>
    public partial class ItinerarioDetalleMapper : BaseGateway<ItinerarioDetalle, ItinerarioDetalleList>, IGenericGateway
    {


        #region "Singleton"

        static ItinerarioDetalleMapper _instance;

        private ItinerarioDetalleMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItinerarioDetalleMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ItinerarioDetalleMapper();
                else {
                    ItinerarioDetalleMapper inst = HttpContext.Current.Items["serin_viaticosRules.ItinerarioDetalleMapperSingleton"] as ItinerarioDetalleMapper;
                    if (inst == null) {
                        inst = new ItinerarioDetalleMapper();
                        HttpContext.Current.Items.Add("serin_viaticosRules.ItinerarioDetalleMapperSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={"IdItinerarioDetalle"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ItinerarioDetalle);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ItinerarioDetalle"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ItinerarioDetalleMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ItinerarioDetalle entity)
        {
            
            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            ItinerarioDetalle.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ItinerarioDetalle entity)
        {

            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            return ItinerarioDetalle.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ItinerarioDetalle entity)
        {

            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            return ItinerarioDetalle.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ItinerarioDetalle entity)
        {

            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            return ItinerarioDetalle.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ItinerarioDetalle entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableItinerarioDetalleObject) entity).UpdateObjectFromOutputParams(parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        


        

        /// <summary>
        /// Complete the aggregations for this entity. 
        /// </summary>
        protected override void CompleteEntity(ItinerarioDetalle entity)
        {
            Entities.Itinerario ItinerarioEntity = null; // Lazy load
Entities.Ubicaciones UbicacionesEntity = null; // Lazy load
            ((IMappeableItinerarioDetalle)entity).CompleteEntity(ItinerarioEntity, UbicacionesEntity);
        }


        # region CRUD Operations
        

        # endregion

        /// <summary>
        /// Delete children for this entity
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, IUniqueIdentifiable entity)
        {
                        
        }


          





        /// <summary>
        /// Get a ItinerarioDetalle by execute a SQL Query Text
        /// </summary>
        public ItinerarioDetalle GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ItinerarioDetalleList by execute a SQL Query Text
        /// </summary>
        public ItinerarioDetalleList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalle GetOne(System.Int32 IdItinerarioDetalle)
        {
            return base.GetOne(new ItinerarioDetalle(IdItinerarioDetalle));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByItinerario(DbTransaction transaction, System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByUbicaciones(DbTransaction transaction, System.Int32 IdParada)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", IdParada);
        }

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByUbicaciones(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", Ubicaciones.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByItinerario(System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByItinerario(IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByUbicaciones(System.Int32 IdParada)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", IdParada);
        }

        /// <summary>
        /// 
        /// </summary>
        public ItinerarioDetalleList GetByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", Ubicaciones.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdItinerarioDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_Delete", IdItinerarioDetalle);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdItinerarioDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_Delete", IdItinerarioDetalle);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByItinerario(System.Int32 IdItinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", IdItinerario);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByItinerario(DbTransaction transaction, System.Int32 IdItinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", IdItinerario);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByItinerario(IUniqueIdentifiable Itinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", Itinerario.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByItinerario", Itinerario.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByUbicaciones(System.Int32 IdParada)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", IdParada);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByUbicaciones(DbTransaction transaction, System.Int32 IdParada)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", IdParada);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_DeleteByUbicaciones", Ubicaciones.Identifier());
        }

        /// <summary>
        /// 
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

namespace serin_viaticosRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class ItinerarioDetalleMapperWrapper
    {

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            return Instance().GetPKPropertiesNames();
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return Instance().GetMappingType();
        }



        /// <summary>
        /// 
        /// </summary>
        public serin_viaticosRules.Mappers.ItinerarioDetalleMapper Instance()
        {
            return serin_viaticosRules.Mappers.ItinerarioDetalleMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ItinerarioDetalleEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ItinerarioDetalle GetOne(System.Int32 IdItinerarioDetalle) {
            return Instance().GetOne( IdItinerarioDetalle);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ItinerarioDetalleList by calling a Stored Procedure
        /// </summary>
        public Entities.ItinerarioDetalleList GetByItinerario(System.Int32 IdItinerario)
        {
            return Instance().GetByItinerario(IdItinerario);
        }

        /// <summary>
        /// Get a ItinerarioDetalleList by calling a Stored Procedure
        /// </summary>
        public Entities.ItinerarioDetalleList GetByItinerario(IUniqueIdentifiable Itinerario)
        {
            return Instance().GetByItinerario(Itinerario);
        }

    

        /// <summary>
        /// Get a ItinerarioDetalleList by calling a Stored Procedure
        /// </summary>
        public Entities.ItinerarioDetalleList GetByUbicaciones(System.Int32 IdParada)
        {
            return Instance().GetByUbicaciones(IdParada);
        }

        /// <summary>
        /// Get a ItinerarioDetalleList by calling a Stored Procedure
        /// </summary>
        public Entities.ItinerarioDetalleList GetByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            return Instance().GetByUbicaciones(Ubicaciones);
        }

    

       

        /// <summary>
        /// Delete children for ItinerarioDetalle
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ItinerarioDetalle entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete ItinerarioDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(System.Int32 IdItinerario)
        {
            Instance().DeleteByItinerario(IdItinerario);
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Itinerario
        /// </summary>
        public void DeleteByItinerario(IUniqueIdentifiable Itinerario)
        {
            Instance().DeleteByItinerario(Itinerario);
        }

    

        /// <summary>
        /// Delete ItinerarioDetalle by Ubicaciones
        /// </summary>
        public void DeleteByUbicaciones(System.Int32 IdParada)
        {
            Instance().DeleteByUbicaciones(IdParada);
        }

        /// <summary>
        /// Delete ItinerarioDetalle by Ubicaciones
        /// </summary>
        public void DeleteByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            Instance().DeleteByUbicaciones(Ubicaciones);
        }

    
        /// <summary>
        /// Delete ItinerarioDetalle 
        /// </summary>
        public void Delete(System.Int32 IdItinerarioDetalle){
            Instance().Delete(IdItinerarioDetalle);
        }

        /// <summary>
        /// Delete ItinerarioDetalle 
        /// </summary>
        public void Delete(Entities.ItinerarioDetalle entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ItinerarioDetalle  
        /// </summary>
        public void Save(Entities.ItinerarioDetalle entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ItinerarioDetalle 
        /// </summary>
        public void Insert(Entities.ItinerarioDetalle entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ItinerarioDetalle 
        /// </summary>
        public Entities.ItinerarioDetalleList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ItinerarioDetalle 
        /// </summary>
        public void Save(System.Int32 IdItinerarioDetalle, System.Int32 IdItinerario, System.Int32 IdParada){
            Entities.ItinerarioDetalle entity = Instance().GetOne(IdItinerarioDetalle);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdItinerarioDetalle", IdItinerarioDetalle));

            entity.IdItinerario = IdItinerario;
            entity.IdParada = IdParada;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ItinerarioDetalle
        /// </summary>
        public void Insert(System.Int32 IdItinerario, System.Int32 IdParada){
            Entities.ItinerarioDetalle entity = new Entities.ItinerarioDetalle();

            entity.IdItinerario = IdItinerario;
            entity.IdParada = IdParada;
            Instance().Insert(entity);
        }


        //Database Queries 
        


    }
}





namespace serin_viaticosRules.Loaders
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ItinerarioDetalleLoader<T> : BaseLoader< T, ItinerarioDetalle, ObjectList<T>>, IGenericGateway where T : ItinerarioDetalle, new()
    {

        #region "Singleton"

        static ItinerarioDetalleLoader<T> _instance;

        private ItinerarioDetalleLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItinerarioDetalleLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ItinerarioDetalleLoader<T>();
                else {
                    ItinerarioDetalleLoader<T> inst = HttpContext.Current.Items["serin_viaticosRules.ItinerarioDetalleLoaderSingleton"] as ItinerarioDetalleLoader<T>;
                    if (inst == null) {
                        inst = new ItinerarioDetalleLoader<T>();
                        HttpContext.Current.Items.Add("serin_viaticosRules.ItinerarioDetalleLoaderSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={"IdItinerarioDetalle"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ItinerarioDetalle);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ItinerarioDetalle"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ItinerarioDetalle entity)
        {
            
            IMappeableItinerarioDetalleObject ItinerarioDetalle = (IMappeableItinerarioDetalleObject)entity;
            ItinerarioDetalle.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        
    

        

        /// <summary>
        /// Complete the aggregations for this entity. 
        /// </summary>
        protected override void CompleteEntity(T entity)
        {
            Entities.Itinerario ItinerarioEntity = null; // Lazy load
Entities.Ubicaciones UbicacionesEntity = null; // Lazy load
            ((IMappeableItinerarioDetalle)entity).CompleteEntity(ItinerarioEntity, UbicacionesEntity);
        }


        



        /// <summary>
        /// Get a ItinerarioDetalle by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ItinerarioDetalleList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdItinerarioDetalle)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetOne", IdItinerarioDetalle);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByItinerario(DbTransaction transaction, System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByItinerario(DbTransaction transaction, IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByUbicaciones(DbTransaction transaction, System.Int32 IdParada)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", IdParada);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByUbicaciones(DbTransaction transaction, IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", Ubicaciones.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByItinerario(System.Int32 IdItinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", IdItinerario);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByItinerario(IUniqueIdentifiable Itinerario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByItinerario", Itinerario.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByUbicaciones(System.Int32 IdParada)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", IdParada);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByUbicaciones(IUniqueIdentifiable Ubicaciones)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ItinerarioDetalle_GetByUbicaciones", Ubicaciones.Identifier());
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





