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
    
    
    public partial class PlayerTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlayerTypes> Search(Space.Data.Space.PlayerTypes Query) {
            Space.Data.Space.PlayerTypesDAL dal =  new Space.Data.Space.PlayerTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerTypes> Search(Space.Data.Space.PlayerTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerTypesDAL dal =  new Space.Data.Space.PlayerTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerTypes> FullSearch(Space.Data.Space.PlayerTypes Query, Func<Space.Data.Space.PlayerTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerTypesDAL dal =  new Space.Data.Space.PlayerTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlayerTypes Query) {
            Space.Data.Space.PlayerTypesDAL dal =  new Space.Data.Space.PlayerTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlayerTypes Query) {
            Space.Data.Space.PlayerTypesDAL dal =  new Space.Data.Space.PlayerTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlayerTypes Query) {
            Space.Data.Space.PlayerTypesDAL dal =  new Space.Data.Space.PlayerTypesDAL();
            return dal.Delete(Query);
        }
    }
}
