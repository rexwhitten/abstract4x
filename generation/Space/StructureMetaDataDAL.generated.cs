namespace Space.Data.Space {
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Data;
    using System.Xml;
    using System.Xml.Linq;
    using Space;
    using Space.Data;
    using System.Runtime.Serialization;
    
    
    public partial class StructureMetaDataDAL : Space.Data.DataAccessBase {
        
        public StructureMetaDataDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private StructureMetaData Fill(System.Data.DataRow row) {
            StructureMetaData obj = new StructureMetaData();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["PublicId"] != System.DBNull.Value)) {
                obj.PublicId = ((Guid)(row["PublicId"]));
            }
            if ((row["StructureSysId"] != System.DBNull.Value)) {
                obj.StructureSysId = ((int?)(row["StructureSysId"]));
            }
            if ((row["KeyPath"] != System.DBNull.Value)) {
                obj.KeyPath = row["KeyPath"].ToString();
            }
            if ((row["KeyValue"] != System.DBNull.Value)) {
                obj.KeyValue = row["KeyValue"].ToString();
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<StructureMetaData> SelectObjects(StructureMetaData query) {
            Collection<StructureMetaData> objs = new Collection<StructureMetaData>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 StructureMetaData obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(StructureMetaData query) {
            this.Access.CreateProcedureCommand("ssp_StructureMetaData");
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.PublicId == null) {
                this.Access.AddParameter("PublicId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PublicId",query.PublicId, ParameterDirection.Input);
            }
            if (query.StructureSysId == null) {
                this.Access.AddParameter("StructureSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("StructureSysId",query.StructureSysId, ParameterDirection.Input);
            }
            if (query.KeyPath == null) {
                this.Access.AddParameter("KeyPath", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("KeyPath",query.KeyPath, ParameterDirection.Input);
            }
            if (query.KeyValue == null) {
                this.Access.AddParameter("KeyValue", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("KeyValue",query.KeyValue, ParameterDirection.Input);
            }
            if (query.Active == null) {
                this.Access.AddParameter("Active", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Active",query.Active, ParameterDirection.Input);
            }
            return this.Access.ExecuteDataSet();
        }
        
        // Updates a Record
        public virtual int Update(System.Nullable<int> pSysId, System.Guid pPublicId, System.Nullable<int> pStructureSysId, string pKeyPath, string pKeyValue, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("PublicId", pPublicId, ParameterDirection.Input);
            this.Access.AddParameter("StructureSysId", pStructureSysId, ParameterDirection.Input);
            this.Access.AddParameter("KeyPath", pKeyPath, ParameterDirection.Input);
            this.Access.AddParameter("KeyValue", pKeyValue, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(StructureMetaData query) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.PublicId == null) {
                this.Access.AddParameter("PublicId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PublicId",query.PublicId, ParameterDirection.Input);
            }
            if (query.StructureSysId == null) {
                this.Access.AddParameter("StructureSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("StructureSysId",query.StructureSysId, ParameterDirection.Input);
            }
            if (query.KeyPath == null) {
                this.Access.AddParameter("KeyPath", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("KeyPath",query.KeyPath, ParameterDirection.Input);
            }
            if (query.KeyValue == null) {
                this.Access.AddParameter("KeyValue", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("KeyValue",query.KeyValue, ParameterDirection.Input);
            }
            if (query.Active == null) {
                this.Access.AddParameter("Active", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Active",query.Active, ParameterDirection.Input);
            }
            int value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(StructureMetaData query) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Guid pPublicId, System.Nullable<int> pStructureSysId, string pKeyPath, string pKeyValue, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("PublicId", pPublicId , ParameterDirection.Input);
            this.Access.AddParameter("StructureSysId", pStructureSysId , ParameterDirection.Input);
            this.Access.AddParameter("KeyPath", pKeyPath , ParameterDirection.Input);
            this.Access.AddParameter("KeyValue", pKeyValue , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(StructureMetaData query) {
            this.Access.CreateProcedureCommand("cp_StructureMetaData");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.PublicId == null) {
                this.Access.AddParameter("PublicId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PublicId",query.PublicId, ParameterDirection.Input);
            }
            if (query.StructureSysId == null) {
                this.Access.AddParameter("StructureSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("StructureSysId",query.StructureSysId, ParameterDirection.Input);
            }
            if (query.KeyPath == null) {
                this.Access.AddParameter("KeyPath", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("KeyPath",query.KeyPath, ParameterDirection.Input);
            }
            if (query.KeyValue == null) {
                this.Access.AddParameter("KeyValue", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("KeyValue",query.KeyValue, ParameterDirection.Input);
            }
            if (query.Active == null) {
                this.Access.AddParameter("Active", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Active",query.Active, ParameterDirection.Input);
            }
            return this.Access.ExecuteNonQuery();
        }
    }
}
