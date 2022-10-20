
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is SolicitudesUsuariosMapper.cs
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
    public partial class SolicitudesUsuariosMapper : BaseGateway<SolicitudesUsuarios, SolicitudesUsuariosList>, IGenericGateway
    {


        #region "Singleton"

        static SolicitudesUsuariosMapper _instance;

        private SolicitudesUsuariosMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static SolicitudesUsuariosMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new SolicitudesUsuariosMapper();
                else {
                    SolicitudesUsuariosMapper inst = HttpContext.Current.Items["serin_viaticosRules.SolicitudesUsuariosMapperSingleton"] as SolicitudesUsuariosMapper;
                    if (inst == null) {
                        inst = new SolicitudesUsuariosMapper();
                        HttpContext.Current.Items.Add("serin_viaticosRules.SolicitudesUsuariosMapperSingleton", inst);
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
            
            string[] s ={"IdSolicitudUsuario"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(SolicitudesUsuarios);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "SolicitudesUsuarios"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(SolicitudesUsuariosMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, SolicitudesUsuarios entity)
        {
            
            IMappeableSolicitudesUsuariosObject SolicitudesUsuarios = (IMappeableSolicitudesUsuariosObject)entity;
            SolicitudesUsuarios.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
(reader.IsDBNull(3)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(3));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(SolicitudesUsuarios entity)
        {

            IMappeableSolicitudesUsuariosObject SolicitudesUsuarios = (IMappeableSolicitudesUsuariosObject)entity;
            return SolicitudesUsuarios.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(SolicitudesUsuarios entity)
        {

            IMappeableSolicitudesUsuariosObject SolicitudesUsuarios = (IMappeableSolicitudesUsuariosObject)entity;
            return SolicitudesUsuarios.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(SolicitudesUsuarios entity)
        {

            IMappeableSolicitudesUsuariosObject SolicitudesUsuarios = (IMappeableSolicitudesUsuariosObject)entity;
            return SolicitudesUsuarios.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(SolicitudesUsuarios entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableSolicitudesUsuariosObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(SolicitudesUsuarios entity)
        {
            Entities.Solicitudes SolicitudesEntity = null; // Lazy load
            ((IMappeableSolicitudesUsuarios)entity).CompleteEntity(SolicitudesEntity);
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
        /// Get a SolicitudesUsuarios by execute a SQL Query Text
        /// </summary>
        public SolicitudesUsuarios GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a SolicitudesUsuariosList by execute a SQL Query Text
        /// </summary>
        public SolicitudesUsuariosList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public SolicitudesUsuarios GetOne(System.Int32 IdSolicitudUsuario)
        {
            return base.GetOne(new SolicitudesUsuarios(IdSolicitudUsuario));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesUsuariosList GetBySolicitudes(DbTransaction transaction, System.Int32 IdSolicitud)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", IdSolicitud);
        }

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesUsuariosList GetBySolicitudes(DbTransaction transaction, IUniqueIdentifiable Solicitudes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", Solicitudes.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesUsuariosList GetBySolicitudes(System.Int32 IdSolicitud)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", IdSolicitud);
        }

        /// <summary>
        /// 
        /// </summary>
        public SolicitudesUsuariosList GetBySolicitudes(IUniqueIdentifiable Solicitudes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", Solicitudes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdSolicitudUsuario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_Delete", IdSolicitudUsuario);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdSolicitudUsuario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_Delete", IdSolicitudUsuario);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudes(System.Int32 IdSolicitud)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_DeleteBySolicitudes", IdSolicitud);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudes(DbTransaction transaction, System.Int32 IdSolicitud)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_DeleteBySolicitudes", IdSolicitud);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudes(IUniqueIdentifiable Solicitudes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_DeleteBySolicitudes", Solicitudes.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteBySolicitudes(DbTransaction transaction, IUniqueIdentifiable Solicitudes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_DeleteBySolicitudes", Solicitudes.Identifier());
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
    public class SolicitudesUsuariosMapperWrapper
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
        public serin_viaticosRules.Mappers.SolicitudesUsuariosMapper Instance()
        {
            return serin_viaticosRules.Mappers.SolicitudesUsuariosMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a SolicitudesUsuariosEntity by calling a Stored Procedure
        /// </summary>
        public Entities.SolicitudesUsuarios GetOne(System.Int32 IdSolicitudUsuario) {
            return Instance().GetOne( IdSolicitudUsuario);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a SolicitudesUsuariosList by calling a Stored Procedure
        /// </summary>
        public Entities.SolicitudesUsuariosList GetBySolicitudes(System.Int32 IdSolicitud)
        {
            return Instance().GetBySolicitudes(IdSolicitud);
        }

        /// <summary>
        /// Get a SolicitudesUsuariosList by calling a Stored Procedure
        /// </summary>
        public Entities.SolicitudesUsuariosList GetBySolicitudes(IUniqueIdentifiable Solicitudes)
        {
            return Instance().GetBySolicitudes(Solicitudes);
        }

    

       

        /// <summary>
        /// Delete children for SolicitudesUsuarios
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, SolicitudesUsuarios entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete SolicitudesUsuarios by Solicitudes
        /// </summary>
        public void DeleteBySolicitudes(System.Int32 IdSolicitud)
        {
            Instance().DeleteBySolicitudes(IdSolicitud);
        }

        /// <summary>
        /// Delete SolicitudesUsuarios by Solicitudes
        /// </summary>
        public void DeleteBySolicitudes(IUniqueIdentifiable Solicitudes)
        {
            Instance().DeleteBySolicitudes(Solicitudes);
        }

    
        /// <summary>
        /// Delete SolicitudesUsuarios 
        /// </summary>
        public void Delete(System.Int32 IdSolicitudUsuario){
            Instance().Delete(IdSolicitudUsuario);
        }

        /// <summary>
        /// Delete SolicitudesUsuarios 
        /// </summary>
        public void Delete(Entities.SolicitudesUsuarios entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save SolicitudesUsuarios  
        /// </summary>
        public void Save(Entities.SolicitudesUsuarios entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert SolicitudesUsuarios 
        /// </summary>
        public void Insert(Entities.SolicitudesUsuarios entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll SolicitudesUsuarios 
        /// </summary>
        public Entities.SolicitudesUsuariosList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save SolicitudesUsuarios 
        /// </summary>
        public void Save(System.Int32 IdSolicitudUsuario, System.Int32 IdSolicitud, System.Int32 IdUsuario, System.Decimal MontoAnticipo){
            Entities.SolicitudesUsuarios entity = Instance().GetOne(IdSolicitudUsuario);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdSolicitudUsuario", IdSolicitudUsuario));

            entity.IdUsuario = IdUsuario;
            entity.MontoAnticipo = MontoAnticipo;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert SolicitudesUsuarios
        /// </summary>
        public void Insert(System.Int32 IdSolicitudUsuario, System.Int32 IdUsuario, System.Decimal MontoAnticipo){
            Entities.SolicitudesUsuarios entity = new Entities.SolicitudesUsuarios();

            entity.IdSolicitudUsuario = IdSolicitudUsuario;
            entity.IdUsuario = IdUsuario;
            entity.MontoAnticipo = MontoAnticipo;
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
    public partial class SolicitudesUsuariosLoader<T> : BaseLoader< T, SolicitudesUsuarios, ObjectList<T>>, IGenericGateway where T : SolicitudesUsuarios, new()
    {

        #region "Singleton"

        static SolicitudesUsuariosLoader<T> _instance;

        private SolicitudesUsuariosLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static SolicitudesUsuariosLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new SolicitudesUsuariosLoader<T>();
                else {
                    SolicitudesUsuariosLoader<T> inst = HttpContext.Current.Items["serin_viaticosRules.SolicitudesUsuariosLoaderSingleton"] as SolicitudesUsuariosLoader<T>;
                    if (inst == null) {
                        inst = new SolicitudesUsuariosLoader<T>();
                        HttpContext.Current.Items.Add("serin_viaticosRules.SolicitudesUsuariosLoaderSingleton", inst);
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
            
            string[] s ={"IdSolicitudUsuario"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(SolicitudesUsuarios);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "SolicitudesUsuarios"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, SolicitudesUsuarios entity)
        {
            
            IMappeableSolicitudesUsuariosObject SolicitudesUsuarios = (IMappeableSolicitudesUsuariosObject)entity;
            SolicitudesUsuarios.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
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
            Entities.Solicitudes SolicitudesEntity = null; // Lazy load
            ((IMappeableSolicitudesUsuarios)entity).CompleteEntity(SolicitudesEntity);
        }


        



        /// <summary>
        /// Get a SolicitudesUsuarios by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a SolicitudesUsuariosList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdSolicitudUsuario)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_GetOne", IdSolicitudUsuario);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudes(DbTransaction transaction, System.Int32 IdSolicitud)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", IdSolicitud);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudes(DbTransaction transaction, IUniqueIdentifiable Solicitudes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", Solicitudes.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudes(System.Int32 IdSolicitud)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", IdSolicitud);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetBySolicitudes(IUniqueIdentifiable Solicitudes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "SolicitudesUsuarios_GetBySolicitudes", Solicitudes.Identifier());
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




