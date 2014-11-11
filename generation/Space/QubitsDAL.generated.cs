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
    
    
    public partial class QubitsDAL : Space.Data.DataAccessBase {
        
        public QubitsDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private Qubits Fill(System.Data.DataRow row) {
            Qubits obj = new Qubits();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["QubitStatusSysId"] != System.DBNull.Value)) {
                obj.QubitStatusSysId = ((int?)(row["QubitStatusSysId"]));
            }
            if ((row["QubitTypeSysId"] != System.DBNull.Value)) {
                obj.QubitTypeSysId = ((int?)(row["QubitTypeSysId"]));
            }
            if ((row["PublicId"] != System.DBNull.Value)) {
                obj.PublicId = ((Guid)(row["PublicId"]));
            }
            if ((row["Path"] != System.DBNull.Value)) {
                obj.Path = row["Path"].ToString();
            }
            if ((row["CreateDate"] != System.DBNull.Value)) {
                obj.CreateDate = ((DateTime?)(row["CreateDate"]));
            }
            if ((row["LastModifiedDate"] != System.DBNull.Value)) {
                obj.LastModifiedDate = ((DateTime?)(row["LastModifiedDate"]));
            }
            if ((row["Is_ReadOnly"] != System.DBNull.Value)) {
                obj.Is_ReadOnly = ((bool?)(row["Is_ReadOnly"]));
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<Qubits> SelectObjects(Qubits query) {
            Collection<Qubits> objs = new Collection<Qubits>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 Qubits obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(Qubits query) {
            this.Access.CreateProcedureCommand("ssp_Qubits");
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.QubitStatusSysId == null) {
                this.Access.AddParameter("QubitStatusSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("QubitStatusSysId",query.QubitStatusSysId, ParameterDirection.Input);
            }
            if (query.QubitTypeSysId == null) {
                this.Access.AddParameter("QubitTypeSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("QubitTypeSysId",query.QubitTypeSysId, ParameterDirection.Input);
            }
            if (query.PublicId == null) {
                this.Access.AddParameter("PublicId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PublicId",query.PublicId, ParameterDirection.Input);
            }
            if (query.Path == null) {
                this.Access.AddParameter("Path", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Path",query.Path, ParameterDirection.Input);
            }
            if (query.CreateDate == null) {
                this.Access.AddParameter("CreateDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CreateDate",query.CreateDate, ParameterDirection.Input);
            }
            if (query.LastModifiedDate == null) {
                this.Access.AddParameter("LastModifiedDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("LastModifiedDate",query.LastModifiedDate, ParameterDirection.Input);
            }
            if (query.Is_ReadOnly == null) {
                this.Access.AddParameter("Is_ReadOnly", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Is_ReadOnly",query.Is_ReadOnly, ParameterDirection.Input);
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
        public virtual int Update(System.Nullable<int> pSysId, System.Nullable<int> pQubitStatusSysId, System.Nullable<int> pQubitTypeSysId, System.Guid pPublicId, string pPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pIs_ReadOnly, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("QubitStatusSysId", pQubitStatusSysId, ParameterDirection.Input);
            this.Access.AddParameter("QubitTypeSysId", pQubitTypeSysId, ParameterDirection.Input);
            this.Access.AddParameter("PublicId", pPublicId, ParameterDirection.Input);
            this.Access.AddParameter("Path", pPath, ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate, ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate, ParameterDirection.Input);
            this.Access.AddParameter("Is_ReadOnly", pIs_ReadOnly, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(Qubits query) {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.QubitStatusSysId == null) {
                this.Access.AddParameter("QubitStatusSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("QubitStatusSysId",query.QubitStatusSysId, ParameterDirection.Input);
            }
            if (query.QubitTypeSysId == null) {
                this.Access.AddParameter("QubitTypeSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("QubitTypeSysId",query.QubitTypeSysId, ParameterDirection.Input);
            }
            if (query.PublicId == null) {
                this.Access.AddParameter("PublicId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PublicId",query.PublicId, ParameterDirection.Input);
            }
            if (query.Path == null) {
                this.Access.AddParameter("Path", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Path",query.Path, ParameterDirection.Input);
            }
            if (query.CreateDate == null) {
                this.Access.AddParameter("CreateDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CreateDate",query.CreateDate, ParameterDirection.Input);
            }
            if (query.LastModifiedDate == null) {
                this.Access.AddParameter("LastModifiedDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("LastModifiedDate",query.LastModifiedDate, ParameterDirection.Input);
            }
            if (query.Is_ReadOnly == null) {
                this.Access.AddParameter("Is_ReadOnly", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Is_ReadOnly",query.Is_ReadOnly, ParameterDirection.Input);
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
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(Qubits query) {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Nullable<int> pQubitStatusSysId, System.Nullable<int> pQubitTypeSysId, System.Guid pPublicId, string pPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pIs_ReadOnly, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("QubitStatusSysId", pQubitStatusSysId , ParameterDirection.Input);
            this.Access.AddParameter("QubitTypeSysId", pQubitTypeSysId , ParameterDirection.Input);
            this.Access.AddParameter("PublicId", pPublicId , ParameterDirection.Input);
            this.Access.AddParameter("Path", pPath , ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate , ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate , ParameterDirection.Input);
            this.Access.AddParameter("Is_ReadOnly", pIs_ReadOnly , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(Qubits query) {
            this.Access.CreateProcedureCommand("cp_Qubits");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.QubitStatusSysId == null) {
                this.Access.AddParameter("QubitStatusSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("QubitStatusSysId",query.QubitStatusSysId, ParameterDirection.Input);
            }
            if (query.QubitTypeSysId == null) {
                this.Access.AddParameter("QubitTypeSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("QubitTypeSysId",query.QubitTypeSysId, ParameterDirection.Input);
            }
            if (query.PublicId == null) {
                this.Access.AddParameter("PublicId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PublicId",query.PublicId, ParameterDirection.Input);
            }
            if (query.Path == null) {
                this.Access.AddParameter("Path", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Path",query.Path, ParameterDirection.Input);
            }
            if (query.CreateDate == null) {
                this.Access.AddParameter("CreateDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CreateDate",query.CreateDate, ParameterDirection.Input);
            }
            if (query.LastModifiedDate == null) {
                this.Access.AddParameter("LastModifiedDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("LastModifiedDate",query.LastModifiedDate, ParameterDirection.Input);
            }
            if (query.Is_ReadOnly == null) {
                this.Access.AddParameter("Is_ReadOnly", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Is_ReadOnly",query.Is_ReadOnly, ParameterDirection.Input);
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