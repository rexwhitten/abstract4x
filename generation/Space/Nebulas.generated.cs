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
    public partial class Nebulas {
        
        private System.Nullable<int> _SysId;
        
        private System.Nullable<int> _NebulaStatusSysId;
        
        private System.Nullable<int> _NebulaTypeSysId;
        
        private System.Guid _PublicId;
        
        private string _Path;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<System.DateTime> _LastModifiedDate;
        
        private System.Nullable<bool> _Is_ReadOnly;
        
        private System.Nullable<bool> _Active;
        
        public Nebulas() {
        }
        
        public Nebulas(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public Nebulas(System.Nullable<int> pSysId, System.Nullable<int> pNebulaStatusSysId, System.Nullable<int> pNebulaTypeSysId, System.Guid pPublicId, string pPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pIs_ReadOnly, System.Nullable<bool> pActive) {
            this._SysId=pSysId;
            this._NebulaStatusSysId=pNebulaStatusSysId;
            this._NebulaTypeSysId=pNebulaTypeSysId;
            this._PublicId=pPublicId;
            this._Path=pPath;
            this._CreateDate=pCreateDate;
            this._LastModifiedDate=pLastModifiedDate;
            this._Is_ReadOnly=pIs_ReadOnly;
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
        public virtual System.Nullable<int> NebulaStatusSysId {
            get {
                return this._NebulaStatusSysId;
            }
            set {
                 this._NebulaStatusSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> NebulaTypeSysId {
            get {
                return this._NebulaTypeSysId;
            }
            set {
                 this._NebulaTypeSysId = value;
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
        public virtual string Path {
            get {
                return this._Path;
            }
            set {
                 this._Path = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<System.DateTime> CreateDate {
            get {
                return this._CreateDate;
            }
            set {
                 this._CreateDate = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<System.DateTime> LastModifiedDate {
            get {
                return this._LastModifiedDate;
            }
            set {
                 this._LastModifiedDate = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<bool> Is_ReadOnly {
            get {
                return this._Is_ReadOnly;
            }
            set {
                 this._Is_ReadOnly = value;
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
