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
    
    
    public partial class AsteroidFiledTagsDAL : Space.Data.DataAccessBase {
        
        public AsteroidFiledTagsDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private AsteroidFiledTags Fill(System.Data.DataRow row) {
            AsteroidFiledTags obj = new AsteroidFiledTags();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["AsteroidFiledSysId"] != System.DBNull.Value)) {
                obj.AsteroidFiledSysId = ((int?)(row["AsteroidFiledSysId"]));
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
        public virtual Collection<AsteroidFiledTags> SelectObjects(AsteroidFiledTags query) {
            Collection<AsteroidFiledTags> objs = new Collection<AsteroidFiledTags>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 AsteroidFiledTags obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(AsteroidFiledTags query) {
            this.Access.CreateProcedureCommand("ssp_AsteroidFiledTags");
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.AsteroidFiledSysId == null) {
                this.Access.AddParameter("AsteroidFiledSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("AsteroidFiledSysId",query.AsteroidFiledSysId, ParameterDirection.Input);
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
        public virtual int Update(System.Nullable<int> pSysId, System.Nullable<int> pAsteroidFiledSysId, string pTag, System.Nullable<System.DateTime> pCreateDate, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("AsteroidFiledSysId", pAsteroidFiledSysId, ParameterDirection.Input);
            this.Access.AddParameter("Tag", pTag, ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(AsteroidFiledTags query) {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.AsteroidFiledSysId == null) {
                this.Access.AddParameter("AsteroidFiledSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("AsteroidFiledSysId",query.AsteroidFiledSysId, ParameterDirection.Input);
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
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(AsteroidFiledTags query) {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Nullable<int> pAsteroidFiledSysId, string pTag, System.Nullable<System.DateTime> pCreateDate, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("AsteroidFiledSysId", pAsteroidFiledSysId , ParameterDirection.Input);
            this.Access.AddParameter("Tag", pTag , ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(AsteroidFiledTags query) {
            this.Access.CreateProcedureCommand("cp_AsteroidFiledTags");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.AsteroidFiledSysId == null) {
                this.Access.AddParameter("AsteroidFiledSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("AsteroidFiledSysId",query.AsteroidFiledSysId, ParameterDirection.Input);
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
