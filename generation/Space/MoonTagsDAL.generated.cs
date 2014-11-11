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
    
    
    public partial class MoonTagsDAL : Space.Data.DataAccessBase {
        
        public MoonTagsDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private MoonTags Fill(System.Data.DataRow row) {
            MoonTags obj = new MoonTags();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["MoonSysId"] != System.DBNull.Value)) {
                obj.MoonSysId = ((int?)(row["MoonSysId"]));
            }
            if ((row["Tag"] != System.DBNull.Value)) {
                obj.Tag = row["Tag"].ToString();
            }
            if ((row["CreateDate"] != System.DBNull.Value)) {
                obj.CreateDate = ((DateTime?)(row["CreateDate"]));
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<MoonTags> SelectObjects(MoonTags query) {
            Collection<MoonTags> objs = new Collection<MoonTags>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 MoonTags obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(MoonTags query) {
            this.Access.CreateProcedureCommand("ssp_MoonTags");
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.MoonSysId == null) {
                this.Access.AddParameter("MoonSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("MoonSysId",query.MoonSysId, ParameterDirection.Input);
            }
            if (query.Tag == null) {
                this.Access.AddParameter("Tag", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Tag",query.Tag, ParameterDirection.Input);
            }
            if (query.CreateDate == null) {
                this.Access.AddParameter("CreateDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CreateDate",query.CreateDate, ParameterDirection.Input);
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
        public virtual int Update(System.Nullable<int> pSysId, System.Nullable<int> pMoonSysId, string pTag, System.Nullable<System.DateTime> pCreateDate, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("MoonSysId", pMoonSysId, ParameterDirection.Input);
            this.Access.AddParameter("Tag", pTag, ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(MoonTags query) {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.MoonSysId == null) {
                this.Access.AddParameter("MoonSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("MoonSysId",query.MoonSysId, ParameterDirection.Input);
            }
            if (query.Tag == null) {
                this.Access.AddParameter("Tag", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Tag",query.Tag, ParameterDirection.Input);
            }
            if (query.CreateDate == null) {
                this.Access.AddParameter("CreateDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CreateDate",query.CreateDate, ParameterDirection.Input);
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
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(MoonTags query) {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Nullable<int> pMoonSysId, string pTag, System.Nullable<System.DateTime> pCreateDate, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("MoonSysId", pMoonSysId , ParameterDirection.Input);
            this.Access.AddParameter("Tag", pTag , ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(MoonTags query) {
            this.Access.CreateProcedureCommand("cp_MoonTags");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.MoonSysId == null) {
                this.Access.AddParameter("MoonSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("MoonSysId",query.MoonSysId, ParameterDirection.Input);
            }
            if (query.Tag == null) {
                this.Access.AddParameter("Tag", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Tag",query.Tag, ParameterDirection.Input);
            }
            if (query.CreateDate == null) {
                this.Access.AddParameter("CreateDate", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CreateDate",query.CreateDate, ParameterDirection.Input);
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
