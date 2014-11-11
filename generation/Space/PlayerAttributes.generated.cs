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
    public partial class PlayerAttributes {
        
        private System.Nullable<int> _SysId;
        
        private System.Nullable<int> _PlayerSysId;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<System.DateTime> _LastModifiedDate;
        
        private string _Email;
        
        private string _Username;
        
        private string _PasswordHash;
        
        public PlayerAttributes() {
        }
        
        public PlayerAttributes(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public PlayerAttributes(System.Nullable<int> pSysId, System.Nullable<int> pPlayerSysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, string pEmail, string pUsername, string pPasswordHash) {
            this._SysId=pSysId;
            this._PlayerSysId=pPlayerSysId;
            this._CreateDate=pCreateDate;
            this._LastModifiedDate=pLastModifiedDate;
            this._Email=pEmail;
            this._Username=pUsername;
            this._PasswordHash=pPasswordHash;
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
        public virtual System.Nullable<int> PlayerSysId {
            get {
                return this._PlayerSysId;
            }
            set {
                 this._PlayerSysId = value;
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
        public virtual string Email {
            get {
                return this._Email;
            }
            set {
                 this._Email = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string Username {
            get {
                return this._Username;
            }
            set {
                 this._Username = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string PasswordHash {
            get {
                return this._PasswordHash;
            }
            set {
                 this._PasswordHash = value;
            }
        }
    }
}
