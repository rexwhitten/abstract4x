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
    public partial class Objects {
        
        private System.Nullable<int> _Id;
        
        private string _Title;
        
        private string _Path;
        
        private System.Nullable<bool> _Active;
        
        public Objects() {
        }
        
        public Objects(System.Nullable<int> pId) {
            this._Id=pId;
        }
        
        public Objects(System.Nullable<int> pId, string pTitle, string pPath, System.Nullable<bool> pActive) {
            this._Id=pId;
            this._Title=pTitle;
            this._Path=pPath;
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
        public virtual string Title {
            get {
                return this._Title;
            }
            set {
                 this._Title = value;
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
