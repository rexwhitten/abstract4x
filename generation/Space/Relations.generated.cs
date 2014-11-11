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
    public partial class Relations {
        
        private System.Nullable<int> _Id;
        
        private string _Parent;
        
        private string _Child;
        
        private System.Nullable<bool> _Active;
        
        public Relations() {
        }
        
        public Relations(System.Nullable<int> pId) {
            this._Id=pId;
        }
        
        public Relations(System.Nullable<int> pId, string pParent, string pChild, System.Nullable<bool> pActive) {
            this._Id=pId;
            this._Parent=pParent;
            this._Child=pChild;
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
        public virtual string Parent {
            get {
                return this._Parent;
            }
            set {
                 this._Parent = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string Child {
            get {
                return this._Child;
            }
            set {
                 this._Child = value;
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
