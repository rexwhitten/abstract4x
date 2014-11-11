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
    public partial class Locations {
        
        private System.Nullable<int> _SysId;
        
        private System.Nullable<int> _LocationStatusSysId;
        
        private System.Nullable<int> _LocationTypeSysId;
        
        private System.Guid _PublicId;
        
        private string _Path;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<System.DateTime> _LastModifiedDate;
        
        private System.Nullable<bool> _Is_ReadOnly;
        
        private System.Nullable<bool> _Active;
        
        public Locations() {
        }
        
        public Locations(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public Locations(System.Nullable<int> pSysId, System.Nullable<int> pLocationStatusSysId, System.Nullable<int> pLocationTypeSysId, System.Guid pPublicId, string pPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pIs_ReadOnly, System.Nullable<bool> pActive) {
            this._SysId=pSysId;
            this._LocationStatusSysId=pLocationStatusSysId;
            this._LocationTypeSysId=pLocationTypeSysId;
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
        public virtual System.Nullable<int> LocationStatusSysId {
            get {
                return this._LocationStatusSysId;
            }
            set {
                 this._LocationStatusSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> LocationTypeSysId {
            get {
                return this._LocationTypeSysId;
            }
            set {
                 this._LocationTypeSysId = value;
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
