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
    
    
    public partial class AttributesDAL : Space.Data.DataAccessBase {
        
        public AttributesDAL() : 
                base("Space") {
        }
        
        // Returns a Hydrated POCO
        private Attributes Fill(System.Data.DataRow row) {
            Attributes obj = new Attributes();
            if ((row["Id"] != System.DBNull.Value)) {
                obj.Id = ((int?)(row["Id"]));
            }
            if ((row["ObjectTitle"] != System.DBNull.Value)) {
                obj.ObjectTitle = row["ObjectTitle"].ToString();
            }
            if ((row["Name"] != System.DBNull.Value)) {
                obj.Name = row["Name"].ToString();
            }
            if ((row["DataType"] != System.DBNull.Value)) {
                obj.DataType = row["DataType"].ToString();
            }
            if ((row["Active"] != System.DBNull.Value)) {
                obj.Active = ((bool?)(row["Active"]));
            }
            return obj;
        }
        
        // Returns an IEnumerable of Hydrated POCO's
        public virtual Collection<Attributes> SelectObjects(Attributes query) {
            Collection<Attributes> objs = new Collection<Attributes>();
            DataSet dsResults = Select(query);
            System.Collections.IEnumerator e = dsResults.Tables[0].Rows.GetEnumerator();
while(e.MoveNext()) { 
 DataRow row = (DataRow)e.Current;
 Attributes obj = Fill(row);
 objs.Add(obj);
 }
            return objs;
        }
        
        // Selects One By Primary Key, returns a Data Set
        public virtual System.Data.DataSet Select(System.Nullable<int> pId) {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 1, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            var value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select All [Use Caution]
        public virtual System.Data.DataSet SelectAll() {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 2, ParameterDirection.Input);
            DataSet value = this.Access.ExecuteDataSet();
            return value;
        }
        
        // Select by Object [Implements Query By Example], returns DataSet
        public virtual System.Data.DataSet Select(Attributes query) {
            this.Access.CreateProcedureCommand("ssp_Attributes");
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.ObjectTitle == null) {
                this.Access.AddParameter("ObjectTitle", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ObjectTitle",query.ObjectTitle, ParameterDirection.Input);
            }
            if (query.Name == null) {
                this.Access.AddParameter("Name", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Name",query.Name, ParameterDirection.Input);
            }
            if (query.DataType == null) {
                this.Access.AddParameter("DataType", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("DataType",query.DataType, ParameterDirection.Input);
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
        public virtual int Update(System.Nullable<int> pId, string pObjectTitle, string pName, string pDataType, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            this.Access.AddParameter("ObjectTitle", pObjectTitle, ParameterDirection.Input);
            this.Access.AddParameter("Name", pName, ParameterDirection.Input);
            this.Access.AddParameter("DataType", pDataType, ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive, ParameterDirection.Input);
            var value  = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Updates a Record
        public virtual int Update(Attributes query) {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 4, ParameterDirection.Input);
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.ObjectTitle == null) {
                this.Access.AddParameter("ObjectTitle", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ObjectTitle",query.ObjectTitle, ParameterDirection.Input);
            }
            if (query.Name == null) {
                this.Access.AddParameter("Name", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Name",query.Name, ParameterDirection.Input);
            }
            if (query.DataType == null) {
                this.Access.AddParameter("DataType", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("DataType",query.DataType, ParameterDirection.Input);
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
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Delete's a record
        public virtual int Delete(Attributes query) {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 6, ParameterDirection.Input);
            this.Access.AddParameter("Id", query.Id, ParameterDirection.Input);
            var value = this.Access.ExecuteNonQuery();
            return value;
        }
        
        // Inserts a record
        public virtual int Insert(System.Nullable<int> pId, string pObjectTitle, string pName, string pDataType, System.Nullable<bool> pActive) {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            this.Access.AddParameter("Id", pId , ParameterDirection.Input);
            this.Access.AddParameter("ObjectTitle", pObjectTitle , ParameterDirection.Input);
            this.Access.AddParameter("Name", pName , ParameterDirection.Input);
            this.Access.AddParameter("DataType", pDataType , ParameterDirection.Input);
            this.Access.AddParameter("Active", pActive , ParameterDirection.Input);
            return this.Access.ExecuteNonQuery();
        }
        
        // Inserts a record
        public virtual int Insert(Attributes query) {
            this.Access.CreateProcedureCommand("cp_Attributes");
            this.Access.AddParameter("Operation", 5, ParameterDirection.Input);
            if (query.Id == null) {
                this.Access.AddParameter("Id", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Id",query.Id, ParameterDirection.Input);
            }
            if (query.ObjectTitle == null) {
                this.Access.AddParameter("ObjectTitle", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("ObjectTitle",query.ObjectTitle, ParameterDirection.Input);
            }
            if (query.Name == null) {
                this.Access.AddParameter("Name", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("Name",query.Name, ParameterDirection.Input);
            }
            if (query.DataType == null) {
                this.Access.AddParameter("DataType", null , ParameterDirection.Input);
            }
            else {
                this.Access.AddParameter("DataType",query.DataType, ParameterDirection.Input);
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
