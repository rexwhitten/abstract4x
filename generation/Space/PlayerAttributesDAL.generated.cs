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
    
    
    public partial class PlayerAttributesDAL : Space.Data.DataAccessBase {
        
        public PlayerAttributesDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private PlayerAttributes Fill(System.Data.DataRow row) {
            PlayerAttributes obj = new PlayerAttributes();
            if ((row["SysId"] != System.DBNull.Value)) {
                obj.SysId = ((int?)(row["SysId"]));
            }
            if ((row["PlayerSysId"] != System.DBNull.Value)) {
                obj.PlayerSysId = ((int?)(row["PlayerSysId"]));
            }
            if ((row["CreateDate"] != System.DBNull.Value)) {
                obj.CreateDate = ((DateTime?)(row["CreateDate"]));
            }
            if ((row["LastModifiedDate"] != System.DBNull.Value)) {
                obj.LastModifiedDate = ((DateTime?)(row["LastModifiedDate"]));
            }
            if ((row["Email"] != System.DBNull.Value)) {
                obj.Email = row["Email"].ToString();
            }
            if ((row["Username"] != System.DBNull.Value)) {
                obj.Username = row["Username"].ToString();
            }
            if ((row["PasswordHash"] != System.DBNull.Value)) {
                obj.PasswordHash = row["PasswordHash"].ToString();
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<PlayerAttributes> SelectObjects(PlayerAttributes query) {
            Collection<PlayerAttributes> objs = new Collection<PlayerAttributes>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 PlayerAttributes obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(PlayerAttributes query) {
            this.Access.CreateProcedureCommand("ssp_PlayerAttributes");
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.PlayerSysId == null) {
                this.Access.AddParameter("PlayerSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PlayerSysId",query.PlayerSysId, ParameterDirection.Input);
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
            if (query.Email == null) {
                this.Access.AddParameter("Email", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Email",query.Email, ParameterDirection.Input);
            }
            if (query.Username == null) {
                this.Access.AddParameter("Username", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Username",query.Username, ParameterDirection.Input);
            }
            if (query.PasswordHash == null) {
                this.Access.AddParameter("PasswordHash", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PasswordHash",query.PasswordHash, ParameterDirection.Input);
            }
            return this.Access.ExecuteDataSet();
        }
        
        // Updates a Record
        public virtual int Update(System.Nullable<int> pSysId, System.Nullable<int> pPlayerSysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, string pEmail, string pUsername, string pPasswordHash) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            this.Access.AddParameter("PlayerSysId", pPlayerSysId, ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate, ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate, ParameterDirection.Input);
            this.Access.AddParameter("Email", pEmail, ParameterDirection.Input);
            this.Access.AddParameter("Username", pUsername, ParameterDirection.Input);
            this.Access.AddParameter("PasswordHash", pPasswordHash, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(PlayerAttributes query) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.PlayerSysId == null) {
                this.Access.AddParameter("PlayerSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PlayerSysId",query.PlayerSysId, ParameterDirection.Input);
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
            if (query.Email == null) {
                this.Access.AddParameter("Email", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Email",query.Email, ParameterDirection.Input);
            }
            if (query.Username == null) {
                this.Access.AddParameter("Username", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Username",query.Username, ParameterDirection.Input);
            }
            if (query.PasswordHash == null) {
                this.Access.AddParameter("PasswordHash", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PasswordHash",query.PasswordHash, ParameterDirection.Input);
            }
            int value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(System.Nullable<int> pSysId) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(PlayerAttributes query) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("SysId", query.SysId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pSysId, System.Nullable<int> pPlayerSysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, string pEmail, string pUsername, string pPasswordHash) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("SysId", pSysId , ParameterDirection.Input);
            this.Access.AddParameter("PlayerSysId", pPlayerSysId , ParameterDirection.Input);
            this.Access.AddParameter("CreateDate", pCreateDate , ParameterDirection.Input);
            this.Access.AddParameter("LastModifiedDate", pLastModifiedDate , ParameterDirection.Input);
            this.Access.AddParameter("Email", pEmail , ParameterDirection.Input);
            this.Access.AddParameter("Username", pUsername , ParameterDirection.Input);
            this.Access.AddParameter("PasswordHash", pPasswordHash , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(PlayerAttributes query) {
            this.Access.CreateProcedureCommand("cp_PlayerAttributes");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.SysId == null) {
                this.Access.AddParameter("SysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("SysId",query.SysId, ParameterDirection.Input);
            }
            if (query.PlayerSysId == null) {
                this.Access.AddParameter("PlayerSysId", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PlayerSysId",query.PlayerSysId, ParameterDirection.Input);
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
            if (query.Email == null) {
                this.Access.AddParameter("Email", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Email",query.Email, ParameterDirection.Input);
            }
            if (query.Username == null) {
                this.Access.AddParameter("Username", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Username",query.Username, ParameterDirection.Input);
            }
            if (query.PasswordHash == null) {
                this.Access.AddParameter("PasswordHash", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("PasswordHash",query.PasswordHash, ParameterDirection.Input);
            }
            return this.Access.ExecuteNonQuery();
        }
    }
}
