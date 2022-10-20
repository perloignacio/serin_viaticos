
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 
// This is a partial class file. The other one is ConfiguracionesGateway.cs
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

    public partial class ConfiguracionesGateway : BaseGateway<ConfiguracionesObject, ConfiguracionesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ConfiguracionesGateway _instance;

        private ConfiguracionesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ConfiguracionesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ConfiguracionesGateway();
                else {
                    ConfiguracionesGateway inst = HttpContext.Current.Items["serin_viaticosRules.ConfiguracionesGatewaySingleton"] as ConfiguracionesGateway;
                    if (inst == null) {
                        inst = new ConfiguracionesGateway();
                        HttpContext.Current.Items.Add("serin_viaticosRules.ConfiguracionesGatewaySingleton", inst);
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
            get { return "Configuraciones"; }
        }

        protected override string RuleName
        {
            get {return typeof(ConfiguracionesGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ConfiguracionesObject entity)
        {
            
            IMappeableConfiguracionesObject Configuraciones = (IMappeableConfiguracionesObject)entity;
            Configuraciones.HydrateFields(
            reader.GetString(0),
reader.GetString(1));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ConfiguracionesObject entity)
        {

            IMappeableConfiguracionesObject Configuraciones = (IMappeableConfiguracionesObject)entity;
            return Configuraciones.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ConfiguracionesObject entity)
        {

            IMappeableConfiguracionesObject Configuraciones = (IMappeableConfiguracionesObject)entity;
            return Configuraciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ConfiguracionesObject entity)
        {

            IMappeableConfiguracionesObject Configuraciones = (IMappeableConfiguracionesObject)entity;
            return Configuraciones.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ConfiguracionesObject row, object[] parameters)
        {
            ((IMappeableConfiguracionesObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ConfiguracionesObject by execute a SQL Query Text
        /// </summary>
        public ConfiguracionesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ConfiguracionesObjectList by execute a SQL Query Text
        /// </summary>
        public ConfiguracionesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ConfiguracionesObject by calling a Stored Procedure
        /// </summary>
        public ConfiguracionesObject GetOne(System.String Clave)
        {
            return base.GetOne(new ConfiguracionesObject(Clave));
        }


        // GetBy Objects and Params
            


        

        

        /// <summary>
        /// Delete Configuraciones
        /// </summary>
        public void Delete(System.String Clave)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Configuraciones_Delete", Clave);
        }

        /// <summary>
        /// Delete Configuraciones
        /// </summary>
        public void Delete(DbTransaction transaction, System.String Clave)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Configuraciones_Delete", Clave);
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








