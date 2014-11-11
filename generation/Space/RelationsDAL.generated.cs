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
    
    
    public partial class RelationsDAL : Space.Data.DataAccessBase {
        
        public RelationsDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private Relations Fill(System.Data.DataRow row) {
            Relations obj = new Relations();
            if ((row["Id"] != System.DBNull.Value)) {
                obj.Id = ((int?)(row["Id"]));
            }
            if ((row["Parent"] != System.DBNull.Value)) {
                obj.Parent = row["Parent"].ToString();
            }
            if ((row["Child"] != System.DBNull.Value)) {
                obj.Child = row["Child"].ToString();
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<Relations> SelectObjects(Relations query) {
            Collection<Relations> objs = new Collection<Relations>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 Relations obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pId) {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(Relations query) {
            this.Access.CreateProcedureCommand("ssp_Relations");
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.Parent == null) {
                this.Access.AddParameter("Parent", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Parent",query.Parent, ParameterDirection.Input);
            }
            if (query.Child == null) {
                this.Access.AddParameter("Child", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Child",query.Child, ParameterDirection.Input);
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
        public virtual int Update(System.Nullable<int> pId, string pParent, string pChild, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            this.Access.AddParameter("Parent", pParent, ParameterDirection.Input);
            this.Access.AddParameter("Child", pChild, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(Relations query) {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.Parent == null) {
                this.Access.AddParameter("Parent", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Parent",query.Parent, ParameterDirection.Input);
            }
            if (query.Child == null) {
                this.Access.AddParameter("Child", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Child",query.Child, ParameterDirection.Input);
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
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(Relations query) {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("Id", query.Id, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pId, string pParent, string pChild, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId , ParameterDirection.Input);
            this.Access.AddParameter("Parent", pParent , ParameterDirection.Input);
            this.Access.AddParameter("Child", pChild , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(Relations query) {
            this.Access.CreateProcedureCommand("cp_Relations");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.Parent == null) {
                this.Access.AddParameter("Parent", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Parent",query.Parent, ParameterDirection.Input);
            }
            if (query.Child == null) {
                this.Access.AddParameter("Child", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Child",query.Child, ParameterDirection.Input);
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
