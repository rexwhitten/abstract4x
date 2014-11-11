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
    public partial class TechTreeLinks {
        
        private System.Nullable<int> _SysId;
        
        private System.Guid _PublicId;
        
        private System.Nullable<int> _ParentTechTreeSysId;
        
        private System.Nullable<int> _ChildTechTreeSysId;
        
        private string _LinkPath;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<System.DateTime> _LastModifiedDate;
        
        private System.Nullable<bool> _Active;
        
        public TechTreeLinks() {
        }
        
        public TechTreeLinks(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public TechTreeLinks(System.Nullable<int> pSysId, System.Guid pPublicId, System.Nullable<int> pParentTechTreeSysId, System.Nullable<int> pChildTechTreeSysId, string pLinkPath, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<bool> pActive) {
            this._SysId=pSysId;
            this._PublicId=pPublicId;
            this._ParentTechTreeSysId=pParentTechTreeSysId;
            this._ChildTechTreeSysId=pChildTechTreeSysId;
            this._LinkPath=pLinkPath;
            this._CreateDate=pCreateDate;
            this._LastModifiedDate=pLastModifiedDate;
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
        public virtual System.Nullable<int> ParentTechTreeSysId {
            get {
                return this._ParentTechTreeSysId;
            }
            set {
                 this._ParentTechTreeSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> ChildTechTreeSysId {
            get {
                return this._ChildTechTreeSysId;
            }
            set {
                 this._ChildTechTreeSysId = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string LinkPath {
            get {
                return this._LinkPath;
            }
            set {
                 this._LinkPath = value;
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