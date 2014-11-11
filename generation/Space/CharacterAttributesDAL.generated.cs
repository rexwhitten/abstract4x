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
    
    
    public partial class CharacterAttributesDAL : Space.Data.DataAccessBase {
        
        public CharacterAttributesDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private CharacterAttributes Fill(System.Data.DataRow row) {
            CharacterAttributes obj = new CharacterAttributes();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["CharacterSysId"] != System.DBNull.Value)) {
                obj.CharacterSysId = ((int?)(row["CharacterSysId"]));
            }
            if ((row["CreateDate"] != System.DBNull.Value)) {
                obj.CreateDate = ((DateTime?)(row["CreateDate"]));
            }
            if ((row["LastModifiedDate"] != System.DBNull.Value)) {
                obj.LastModifiedDate = ((DateTime?)(row["LastModifiedDate"]));
            }
            if ((row["Score"] != System.DBNull.Value)) {
                obj.Score = ((int?)(row["Score"]));
            }
            if ((row["Level"] != System.DBNull.Value)) {
                obj.Level = ((int?)(row["Level"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<CharacterAttributes> SelectObjects(CharacterAttributes query) {
            Collection<CharacterAttributes> objs = new Collection<CharacterAttributes>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 CharacterAttributes obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(CharacterAttributes query) {
            this.Access.CreateProcedureCommand("ssp_CharacterAttributes");
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.CharacterSysId == null) {
                this.Access.AddParameter("CharacterSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CharacterSysId",query.CharacterSysId, ParameterDirection.Input);
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
            if (query.Score == null) {
                this.Access.AddParameter("Score", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Score",query.Score, ParameterDirection.Input);
            }
            if (query.Level == null) {
                this.Access.AddParameter("Level", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Level",query.Level, ParameterDirection.Input);
            }
            return this.Access.ExecuteDataSet();
        }
        
        // Updates a Record
        public virtual int Update(System.Nullable<int> pSysId, System.Nullable<int> pCharacterSysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<int> pScore, System.Nullable<int> pLevel) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("CharacterSysId", pCharacterSysId, ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate, ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate, ParameterDirection.Input);
            this.Access.AddParameter("Score", pScore, ParameterDirection.Input);
            this.Access.AddParameter("Level", pLevel, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(CharacterAttributes query) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.CharacterSysId == null) {
                this.Access.AddParameter("CharacterSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CharacterSysId",query.CharacterSysId, ParameterDirection.Input);
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
            if (query.Score == null) {
                this.Access.AddParameter("Score", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Score",query.Score, ParameterDirection.Input);
            }
            if (query.Level == null) {
                this.Access.AddParameter("Level", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Level",query.Level, ParameterDirection.Input);
            }
            int value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(CharacterAttributes query) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Nullable<int> pCharacterSysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<int> pScore, System.Nullable<int> pLevel) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("CharacterSysId", pCharacterSysId , ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate , ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate , ParameterDirection.Input);
            this.Access.AddParameter("Score", pScore , ParameterDirection.Input);
            this.Access.AddParameter("Level", pLevel , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(CharacterAttributes query) {
            this.Access.CreateProcedureCommand("cp_CharacterAttributes");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.CharacterSysId == null) {
                this.Access.AddParameter("CharacterSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("CharacterSysId",query.CharacterSysId, ParameterDirection.Input);
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
            if (query.Score == null) {
                this.Access.AddParameter("Score", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Score",query.Score, ParameterDirection.Input);
            }
            if (query.Level == null) {
                this.Access.AddParameter("Level", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Level",query.Level, ParameterDirection.Input);
            }
            return this.Access.ExecuteNonQuery();
        }
    }
}
