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
    public partial class LocationTags {
        
        private System.Nullable<int> _SysId;
        
        private System.Nullable<int> _LocationSysId;
        
        private string _Tag;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<bool> _Active;
        
        public LocationTags() {
        }
        
        public LocationTags(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public LocationTags(System.Nullable<int> pSysId, System.Nullable<int> pLocationSysId, string pTag, System.Nullable<System.DateTime> pCreateDate, System.Nullable<bool> pActive) {
            this._SysId=pSysId;
            this._LocationSysId=pLocationSysId;
            this._Tag=pTag;
            this._CreateDate=pCreateDate;
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
        public virtual System.Nullable<int> LocationSysId {
            get {
                return this._LocationSysId;
            }
            set {
                 this._LocationSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string Tag {
            get {
                return this._Tag;
            }
            set {
                 this._Tag = value;
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
