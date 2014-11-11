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
    
    
    public partial class ObjectsDAL : Space.Data.DataAccessBase {
        
        public ObjectsDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private Objects Fill(System.Data.DataRow row) {
            Objects obj = new Objects();
            if ((row["Id"] != System.DBNull.Value)) {
                obj.Id = ((int?)(row["Id"]));
            }
            if ((row["Title"] != System.DBNull.Value)) {
                obj.Title = row["Title"].ToString();
            }
            if ((row["Path"] != System.DBNull.Value)) {
                obj.Path = row["Path"].ToString();
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<Objects> SelectObjects(Objects query) {
            Collection<Objects> objs = new Collection<Objects>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 Objects obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pId) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(Objects query) {
            this.Access.CreateProcedureCommand("ssp_Objects");
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.Title == null) {
                this.Access.AddParameter("Title", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Title",query.Title, ParameterDirection.Input);
            }
            if (query.Path == null) {
                this.Access.AddParameter("Path", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Path",query.Path, ParameterDirection.Input);
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
        public virtual int Update(System.Nullable<int> pId, string pTitle, string pPath, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            this.Access.AddParameter("Title", pTitle, ParameterDirection.Input);
            this.Access.AddParameter("Path", pPath, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(Objects query) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.Title == null) {
                this.Access.AddParameter("Title", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Title",query.Title, ParameterDirection.Input);
            }
            if (query.Path == null) {
                this.Access.AddParameter("Path", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Path",query.Path, ParameterDirection.Input);
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
        public virtual int Delete(System.Nullable<int> pId) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(Objects query) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("Id", query.Id, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pId, string pTitle, string pPath, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId , ParameterDirection.Input);
            this.Access.AddParameter("Title", pTitle , ParameterDirection.Input);
            this.Access.AddParameter("Path", pPath , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(Objects query) {
            this.Access.CreateProcedureCommand("cp_Objects");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.Title == null) {
                this.Access.AddParameter("Title", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Title",query.Title, ParameterDirection.Input);
            }
            if (query.Path == null) {
                this.Access.AddParameter("Path", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Path",query.Path, ParameterDirection.Input);
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
