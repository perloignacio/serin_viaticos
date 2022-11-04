
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is UbicacionesMapper.cs
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
    public partial class UbicacionesMapper : BaseGateway<Ubicaciones, UbicacionesList>, IGenericGateway
    {


        #region "Singleton"

        static UbicacionesMapper _instance;

        private UbicacionesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static UbicacionesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new UbicacionesMapper();
                else {
                    UbicacionesMapper inst = HttpContext.Current.Items["serin_viaticosRules.UbicacionesMapperSingleton"] as UbicacionesMapper;
                    if (inst == null) {
                        inst = new UbicacionesMapper();
                        HttpContext.Current.Items.Add("serin_viaticosRules.UbicacionesMapperSingleton", inst);
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
            
            string[] s ={"IdUbicacion"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Ubicaciones);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Ubicaciones"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(UbicacionesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Ubicaciones entity)
        {
            
            IMappeableUbicacionesObject Ubicaciones = (IMappeableUbicacionesObject)entity;
            Ubicaciones.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
(reader.IsDBNull(2)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(2),
(reader.IsDBNull(3)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(3));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Ubicaciones entity)
        {

            IMappeableUbicacionesObject Ubicaciones = (IMappeableUbicacionesObject)entity;
            return Ubicaciones.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Ubicaciones entity)
        {

            IMappeableUbicacionesObject Ubicaciones = (IMappeableUbicacionesObject)entity;
            return Ubicaciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Ubicaciones entity)
        {

            IMappeableUbicacionesObject Ubicaciones = (IMappeableUbicacionesObject)entity;
            return Ubicaciones.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Ubicaciones entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableUbicacionesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Ubicaciones entity)
        {
            
            ((IMappeableUbicaciones)entity).CompleteEntity();
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
        /// Get a Ubicaciones by execute a SQL Query Text
        /// </summary>
        public Ubicaciones GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a UbicacionesList by execute a SQL Query Text
        /// </summary>
        public UbicacionesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Ubicaciones GetOne(System.Int32 IdUbicacion)
        {
            return base.GetOne(new Ubicaciones(IdUbicacion));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdUbicacion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Ubicaciones_Delete", IdUbicacion);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdUbicacion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Ubicaciones_Delete", IdUbicacion);
        }


        // Delete By Objects and Params
            



        


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
    public class UbicacionesMapperWrapper
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
        public serin_viaticosRules.Mappers.UbicacionesMapper Instance()
        {
            return serin_viaticosRules.Mappers.UbicacionesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a UbicacionesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Ubicaciones GetOne(System.Int32 IdUbicacion) {
            return Instance().GetOne( IdUbicacion);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for Ubicaciones
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Ubicaciones entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete Ubicaciones 
        /// </summary>
        public void Delete(System.Int32 IdUbicacion){
            Instance().Delete(IdUbicacion);
        }

        /// <summary>
        /// Delete Ubicaciones 
        /// </summary>
        public void Delete(Entities.Ubicaciones entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Ubicaciones  
        /// </summary>
        public void Save(Entities.Ubicaciones entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Ubicaciones 
        /// </summary>
        public void Insert(Entities.Ubicaciones entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Ubicaciones 
        /// </summary>
        public Entities.UbicacionesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Ubicaciones 
        /// </summary>
        public void Save(System.Int32 IdUbicacion, System.String Nombre, System.Decimal Lat, System.Decimal Lng){
            Entities.Ubicaciones entity = Instance().GetOne(IdUbicacion);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdUbicacion", IdUbicacion));

            entity.Nombre = Nombre;
            entity.Lat = Lat;
            entity.Lng = Lng;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Ubicaciones
        /// </summary>
        public void Insert(System.String Nombre, System.Decimal Lat, System.Decimal Lng){
            Entities.Ubicaciones entity = new Entities.Ubicaciones();

            entity.Nombre = Nombre;
            entity.Lat = Lat;
            entity.Lng = Lng;
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
    public partial class UbicacionesLoader<T> : BaseLoader< T, Ubicaciones, ObjectList<T>>, IGenericGateway where T : Ubicaciones, new()
    {

        #region "Singleton"

        static UbicacionesLoader<T> _instance;

        private UbicacionesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static UbicacionesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new UbicacionesLoader<T>();
                else {
                    UbicacionesLoader<T> inst = HttpContext.Current.Items["serin_viaticosRules.UbicacionesLoaderSingleton"] as UbicacionesLoader<T>;
                    if (inst == null) {
                        inst = new UbicacionesLoader<T>();
                        HttpContext.Current.Items.Add("serin_viaticosRules.UbicacionesLoaderSingleton", inst);
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
            
            string[] s ={"IdUbicacion"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Ubicaciones);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Ubicaciones"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Ubicaciones entity)
        {
            
            IMappeableUbicacionesObject Ubicaciones = (IMappeableUbicacionesObject)entity;
            Ubicaciones.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
(reader.IsDBNull(2)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(2),
(reader.IsDBNull(3)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(3));
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
            
            ((IMappeableUbicaciones)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a Ubicaciones by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a UbicacionesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdUbicacion)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Ubicaciones_GetOne", IdUbicacion);
        }


        // GetOne By Objects and Params
            


        


        

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





