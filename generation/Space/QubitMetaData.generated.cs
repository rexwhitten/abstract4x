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
    public partial class QubitMetaData {
        
        private System.Nullable<int> _SysId;
        
        private System.Guid _PublicId;
        
        private System.Nullable<int> _QubitSysId;
        
        private string _KeyPath;
        
        private string _KeyValue;
        
        private System.Nullable<bool> _Active;
        
        public QubitMetaData() {
        }
        
        public QubitMetaData(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public QubitMetaData(System.Nullable<int> pSysId, System.Guid pPublicId, System.Nullable<int> pQubitSysId, string pKeyPath, string pKeyValue, System.Nullable<bool> pActive) {
            this._SysId=pSysId;
            this._PublicId=pPublicId;
            this._QubitSysId=pQubitSysId;
            this._KeyPath=pKeyPath;
            this._KeyValue=pKeyValue;
            this._Active=pActive;
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> SysId {
            get {
                return this._SysId;
            }
            set {
                 this._SysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Guid PublicId {
            get {
                return this._PublicId;
            }
            set {
                 this._PublicId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> QubitSysId {
            get {
                return this._QubitSysId;
            }
            set {
                 this._QubitSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string KeyPath {
            get {
                return this._KeyPath;
            }
            set {
                 this._KeyPath = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string KeyValue {
            get {
                return this._KeyValue;
            }
            set {
                 this._KeyValue = value;
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
