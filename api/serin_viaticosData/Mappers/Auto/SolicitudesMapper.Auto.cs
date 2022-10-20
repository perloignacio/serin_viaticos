
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is SolicitudesMapper.cs
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
    public partial class SolicitudesMapper : BaseGateway<Solicitudes, SolicitudesList>, IGenericGateway
    {


        #region "Singleton"

        static SolicitudesMapper _instance;

        private SolicitudesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static SolicitudesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new SolicitudesMapper();
                else {
                    SolicitudesMapper inst = HttpContext.Current.Items["serin_viaticosRules.SolicitudesMapperSingleton"] as SolicitudesMapper;
                    if (inst == null) {
                        inst = new SolicitudesMapper();
                        HttpContext.Current.Items.Add("serin_viaticosRules.SolicitudesMapperSingleton", inst);
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
            
            string[] s ={"IdSolicitud"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Solicitudes);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Solicitudes"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(SolicitudesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Solicitudes entity)
        {
            
            IMappeableSolicitudesObject Solicitudes = (IMappeableSolicitudesObject)entity;
            Solicitudes.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetInt32(2),
reader.GetInt32(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Solicitudes entity)
        {

            IMappeableSolicitudesObject Solicitudes = (IMappeableSolicitudesObject)entity;
            return Solicitudes.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Solicitudes entity)
        {

            IMappeableSolicitudesObject Solicitudes = (IMappeableSolicitudesObject)entity;
            return Solicitudes.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Solicitudes entity)
        {

            IMappeableSolicitudesObject Solicitudes = (IMappeableSolicitudesObject)entity;
            return Solicitudes.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Solicitudes entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableSolicitudesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Solicitudes entity)
        {
            Entities.SolicitudesEstados SolicitudesEstadosEntity = null; // Lazy load
            ((IMappeableSolicitudes)entity).CompleteEntity(SolicitudesEstadosEntity);
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
        /// Get a Solicitudes by execute a SQL Query Text
        /// </summary>
        public Solicitudes GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a SolicitudesList by execute a SQL Query Text
        /// </summary>
        public SolicitudesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Solicitudes GetOne(System.Int32 IdSolicitud)
        {
            return base.GetOne(new Solicitudes(IdSolicitud));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesList GetBySolicitudesEstados(DbTransaction transaction, System.Int32 IdSolicituEstado)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", IdSolicituEstado);
        }

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesList GetBySolicitudesEstados(DbTransaction transaction, IUniqueIdentifiable SolicitudesEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", SolicitudesEstados.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesList GetBySolicitudesEstados(System.Int32 IdSolicituEstado)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", IdSolicituEstado);
        }

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesList GetBySolicitudesEstados(IUniqueIdentifiable SolicitudesEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", SolicitudesEstados.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdSolicitud)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Solicitudes_Delete", IdSolicitud);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdSolicitud)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_Delete", IdSolicitud);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudesEstados(System.Int32 IdSolicituEstado)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Solicitudes_DeleteBySolicitudesEstados", IdSolicituEstado);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudesEstados(DbTransaction transaction, System.Int32 IdSolicituEstado)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_DeleteBySolicitudesEstados", IdSolicituEstado);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudesEstados(IUniqueIdentifiable SolicitudesEstados)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Solicitudes_DeleteBySolicitudesEstados", SolicitudesEstados.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudesEstados(DbTransaction transaction, IUniqueIdentifiable SolicitudesEstados)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_DeleteBySolicitudesEstados", SolicitudesEstados.Identifier());
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
    public class SolicitudesMapperWrapper
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
        public serin_viaticosRules.Mappers.SolicitudesMapper Instance()
        {
            return serin_viaticosRules.Mappers.SolicitudesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a SolicitudesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Solicitudes GetOne(System.Int32 IdSolicitud) {
            return Instance().GetOne( IdSolicitud);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a SolicitudesList by calling a Stored Procedure
        /// </summary>
        public Entities.SolicitudesList GetBySolicitudesEstados(System.Int32 IdSolicituEstado)
        {
            return Instance().GetBySolicitudesEstados(IdSolicituEstado);
        }

        /// <summary>
        /// Get a SolicitudesList by calling a Stored Procedure
        /// </summary>
        public Entities.SolicitudesList GetBySolicitudesEstados(IUniqueIdentifiable SolicitudesEstados)
        {
            return Instance().GetBySolicitudesEstados(SolicitudesEstados);
        }

    

       

        /// <summary>
        /// Delete children for Solicitudes
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Solicitudes entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Solicitudes by SolicitudesEstados
        /// </summary>
        public void DeleteBySolicitudesEstados(System.Int32 IdSolicituEstado)
        {
            Instance().DeleteBySolicitudesEstados(IdSolicituEstado);
        }

        /// <summary>
        /// Delete Solicitudes by SolicitudesEstados
        /// </summary>
        public void DeleteBySolicitudesEstados(IUniqueIdentifiable SolicitudesEstados)
        {
            Instance().DeleteBySolicitudesEstados(SolicitudesEstados);
        }

    
        /// <summary>
        /// Delete Solicitudes 
        /// </summary>
        public void Delete(System.Int32 IdSolicitud){
            Instance().Delete(IdSolicitud);
        }

        /// <summary>
        /// Delete Solicitudes 
        /// </summary>
        public void Delete(Entities.Solicitudes entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Solicitudes  
        /// </summary>
        public void Save(Entities.Solicitudes entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Solicitudes 
        /// </summary>
        public void Insert(Entities.Solicitudes entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Solicitudes 
        /// </summary>
        public Entities.SolicitudesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Solicitudes 
        /// </summary>
        public void Save(System.Int32 IdSolicitud, System.DateTime Fecha, System.Int32 IdUsuario, System.Int32 IdSolicituEstado, System.String EmailCopia, System.String Descripcion){
            Entities.Solicitudes entity = Instance().GetOne(IdSolicitud);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdSolicitud", IdSolicitud));

            entity.Fecha = Fecha;
            entity.IdUsuario = IdUsuario;
            entity.IdSolicituEstado = IdSolicituEstado;
            entity.EmailCopia = EmailCopia;
            entity.Descripcion = Descripcion;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Solicitudes
        /// </summary>
        public void Insert(System.DateTime Fecha, System.Int32 IdUsuario, System.Int32 IdSolicituEstado, System.String EmailCopia, System.String Descripcion){
            Entities.Solicitudes entity = new Entities.Solicitudes();

            entity.Fecha = Fecha;
            entity.IdUsuario = IdUsuario;
            entity.IdSolicituEstado = IdSolicituEstado;
            entity.EmailCopia = EmailCopia;
            entity.Descripcion = Descripcion;
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
    public partial class SolicitudesLoader<T> : BaseLoader< T, Solicitudes, ObjectList<T>>, IGenericGateway where T : Solicitudes, new()
    {

        #region "Singleton"

        static SolicitudesLoader<T> _instance;

        private SolicitudesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static SolicitudesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new SolicitudesLoader<T>();
                else {
                    SolicitudesLoader<T> inst = HttpContext.Current.Items["serin_viaticosRules.SolicitudesLoaderSingleton"] as SolicitudesLoader<T>;
                    if (inst == null) {
                        inst = new SolicitudesLoader<T>();
                        HttpContext.Current.Items.Add("serin_viaticosRules.SolicitudesLoaderSingleton", inst);
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
            
            string[] s ={"IdSolicitud"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Solicitudes);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Solicitudes"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Solicitudes entity)
        {
            
            IMappeableSolicitudesObject Solicitudes = (IMappeableSolicitudesObject)entity;
            Solicitudes.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetInt32(2),
reader.GetInt32(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5));
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
            Entities.SolicitudesEstados SolicitudesEstadosEntity = null; // Lazy load
            ((IMappeableSolicitudes)entity).CompleteEntity(SolicitudesEstadosEntity);
        }


        



        /// <summary>
        /// Get a Solicitudes by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a SolicitudesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdSolicitud)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Solicitudes_GetOne", IdSolicitud);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudesEstados(DbTransaction transaction, System.Int32 IdSolicituEstado)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", IdSolicituEstado);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudesEstados(DbTransaction transaction, IUniqueIdentifiable SolicitudesEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", SolicitudesEstados.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudesEstados(System.Int32 IdSolicituEstado)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", IdSolicituEstado);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudesEstados(IUniqueIdentifiable SolicitudesEstados)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Solicitudes_GetBySolicitudesEstados", SolicitudesEstados.Identifier());
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




