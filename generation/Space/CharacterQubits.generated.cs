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
    public partial class CharacterQubits {
        
        private System.Nullable<int> _SysId;
        
        private System.Guid _PublicId;
        
        private string _Path;
        
        private System.Nullable<int> _CharacterSysId;
        
        private System.Nullable<int> _QubitsysId;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<bool> _Active;
        
        public CharacterQubits() {
        }
        
        public CharacterQubits(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public CharacterQubits(System.Nullable<int> pSysId, System.Guid pPublicId, string pPath, System.Nullable<int> pCharacterSysId, System.Nullable<int> pQubitsysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<bool> pActive) {
            this._SysId=pSysId;
            this._PublicId=pPublicId;
            this._Path=pPath;
            this._CharacterSysId=pCharacterSysId;
            this._QubitsysId=pQubitsysId;
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
        public virtual System.Nullable<int> CharacterSysId {
            get {
                return this._CharacterSysId;
            }
            set {
                 this._CharacterSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> QubitsysId {
            get {
                return this._QubitsysId;
            }
            set {
                 this._QubitsysId = value;
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
