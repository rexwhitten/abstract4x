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
    
    
    public partial class QubitsLinksDAL : Space.Data.DataAccessBase {
        
        public QubitsLinksDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private QubitsLinks Fill(System.Data.DataRow row) {
            QubitsLinks obj = new QubitsLinks();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["PublicId"] != System.DBNull.Value)) {
                obj.PublicId = ((Guid)(row["PublicId"]));
            }
            if ((row["ParentQubitsSysId"] != System.DBNull.Value)) {
                obj.ParentQubitsSysId = ((int?)(row["ParentQubitsSysId"]));
            }
            if ((row["ChildQubitsSysId"] != System.DBNull.Value)) {
                obj.ChildQubitsSysId = ((int?)(row["ChildQubitsSysId"]));
            }
            if ((row["LinkPath"] != System.DBNull.Value)) {
                obj.LinkPath = row["LinkPath"].ToString();
            }
            if ((row["CreateDate"] != System.DBNull.Value)) {
                obj.CreateDate = ((DateTime?)(row["CreateDate"]));
            }
            if ((row["LastModifiedDate"] != System.DBNull.Value)) {
                obj.LastModifiedDate = ((DateTime?)(row["LastModifiedDate"]));
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<QubitsLinks> SelectObjects(QubitsLinks query) {
            Collection<QubitsLinks> objs = new Collection<QubitsLinks>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 QubitsLinks obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(QubitsLinks query) {
            this.Access.CreateProcedureCommand("ssp_QubitsLinks");
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
            if (query.ParentQubitsSysId == null) {
                this.Access.AddParameter("ParentQubitsSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ParentQubitsSysId",query.ParentQubitsSysId, ParameterDirection.Input);
            }
            if (query.ChildQubitsSysId == null) {
                this.Access.AddParameter("ChildQubitsSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ChildQubitsSysId",query.ChildQubitsSysId, ParameterDirection.Input);
            }
            if (query.LinkPath == null) {
                this.Access.AddParameter("LinkPath", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("LinkPath",query.LinkPath, ParameterDirection.Input);
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
            if (query.Active == null) {
                this.Access.AddParameter("Active", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Active",query.Active, ParameterDirection.Input);
            }
            return this.Access.ExecuteDataSet();
        }
        
        // Updates a Record
        public virtual int Update(System.Nullable<int> pSysId, System.Guid pPublicId, System.Nullable<int> pParentQubitsSysId, System.Nullable<int> pChildQubitsSysId, string pLinkPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("PublicId", pPublicId, ParameterDirection.Input);
            this.Access.AddParameter("ParentQubitsSysId", pParentQubitsSysId, ParameterDirection.Input);
            this.Access.AddParameter("ChildQubitsSysId", pChildQubitsSysId, ParameterDirection.Input);
            this.Access.AddParameter("LinkPath", pLinkPath, ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate, ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(QubitsLinks query) {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
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
            if (query.ParentQubitsSysId == null) {
                this.Access.AddParameter("ParentQubitsSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ParentQubitsSysId",query.ParentQubitsSysId, ParameterDirection.Input);
            }
            if (query.ChildQubitsSysId == null) {
                this.Access.AddParameter("ChildQubitsSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ChildQubitsSysId",query.ChildQubitsSysId, ParameterDirection.Input);
            }
            if (query.LinkPath == null) {
                this.Access.AddParameter("LinkPath", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("LinkPath",query.LinkPath, ParameterDirection.Input);
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
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(QubitsLinks query) {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Guid pPublicId, System.Nullable<int> pParentQubitsSysId, System.Nullable<int> pChildQubitsSysId, string pLinkPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("PublicId", pPublicId , ParameterDirection.Input);
            this.Access.AddParameter("ParentQubitsSysId", pParentQubitsSysId , ParameterDirection.Input);
            this.Access.AddParameter("ChildQubitsSysId", pChildQubitsSysId , ParameterDirection.Input);
            this.Access.AddParameter("LinkPath", pLinkPath , ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate , ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(QubitsLinks query) {
            this.Access.CreateProcedureCommand("cp_QubitsLinks");
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
            if (query.ParentQubitsSysId == null) {
                this.Access.AddParameter("ParentQubitsSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ParentQubitsSysId",query.ParentQubitsSysId, ParameterDirection.Input);
            }
            if (query.ChildQubitsSysId == null) {
                this.Access.AddParameter("ChildQubitsSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ChildQubitsSysId",query.ChildQubitsSysId, ParameterDirection.Input);
            }
            if (query.LinkPath == null) {
                this.Access.AddParameter("LinkPath", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("LinkPath",query.LinkPath, ParameterDirection.Input);
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
