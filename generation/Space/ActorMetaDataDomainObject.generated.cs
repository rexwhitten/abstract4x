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
    
    
    public partial class ActorMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.ActorMetaData> Search(Space.Data.Space.ActorMetaData Query) {
            Space.Data.Space.ActorMetaDataDAL dal =  new Space.Data.Space.ActorMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.ActorMetaData> Search(Space.Data.Space.ActorMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.ActorMetaDataDAL dal =  new Space.Data.Space.ActorMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.ActorMetaData> FullSearch(Space.Data.Space.ActorMetaData Query, Func<Space.Data.Space.ActorMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.ActorMetaDataDAL dal =  new Space.Data.Space.ActorMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.ActorMetaData Query) {
            Space.Data.Space.ActorMetaDataDAL dal =  new Space.Data.Space.ActorMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.ActorMetaData Query) {
            Space.Data.Space.ActorMetaDataDAL dal =  new Space.Data.Space.ActorMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.ActorMetaData Query) {
            Space.Data.Space.ActorMetaDataDAL dal =  new Space.Data.Space.ActorMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
