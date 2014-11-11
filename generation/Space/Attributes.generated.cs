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
    
    
    [ System.Runtime.Serialization.DataContractAttribute()]
    public partial class Attributes {
        
        private System.Nullable<int> _Id;
        
        private string _ObjectTitle;
        
        private string _Name;
        
        private string _DataType;
        
        private System.Nullable<bool> _Active;
        
        public Attributes() {
        }
        
        public Attributes(System.Nullable<int> pId) {
            this._Id=pId;
        }
        
        public Attributes(System.Nullable<int> pId, string pObjectTitle, string pName, string pDataType, System.Nullable<bool> pActive) {
            this._Id=pId;
            this._ObjectTitle=pObjectTitle;
            this._Name=pName;
            this._DataType=pDataType;
            this._Active=pActive;
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> Id {
            get {
                return this._Id;
            }
            set {
                 this._Id = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string ObjectTitle {
            get {
                return this._ObjectTitle;
            }
            set {
                 this._ObjectTitle = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string Name {
            get {
                return this._Name;
            }
            set {
                 this._Name = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string DataType {
            get {
                return this._DataType;
            }
            set {
                 this._DataType = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<bool> Active {
            get {
                return this._Active;
            }
            set {
                 this._Active = value;
            }
        }
    }
}
