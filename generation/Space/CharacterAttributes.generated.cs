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
    public partial class CharacterAttributes {
        
        private System.Nullable<int> _SysId;
        
        private System.Nullable<int> _CharacterSysId;
        
        private System.Nullable<System.DateTime> _CreateDate;
        
        private System.Nullable<System.DateTime> _LastModifiedDate;
        
        private System.Nullable<int> _Score;
        
        private System.Nullable<int> _Level;
        
        public CharacterAttributes() {
        }
        
        public CharacterAttributes(System.Nullable<int> pSysId) {
            this._SysId=pSysId;
        }
        
        public CharacterAttributes(System.Nullable<int> pSysId, System.Nullable<int> pCharacterSysId, System.Nullable<System.DateTime> pCreateDate, System.Nullable<System.DateTime> pLastModifiedDate, System.Nullable<int> pScore, System.Nullable<int> pLevel) {
            this._SysId=pSysId;
            this._CharacterSysId=pCharacterSysId;
            this._CreateDate=pCreateDate;
            this._LastModifiedDate=pLastModifiedDate;
            this._Score=pScore;
            this._Level=pLevel;
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
        public virtual System.Nullable<int> CharacterSysId {
            get {
                return this._CharacterSysId;
            }
            set {
                 this._CharacterSysId = value;
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
        public virtual System.Nullable<int> Score {
            get {
                return this._Score;
            }
            set {
                 this._Score = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual System.Nullable<int> Level {
            get {
                return this._Level;
            }
            set {
                 this._Level = value;
            }
        }
    }
}
