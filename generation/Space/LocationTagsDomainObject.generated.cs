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
    
    
    public partial class LocationTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.LocationTags> Search(Space.Data.Space.LocationTags Query) {
            Space.Data.Space.LocationTagsDAL dal =  new Space.Data.Space.LocationTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.LocationTags> Search(Space.Data.Space.LocationTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.LocationTagsDAL dal =  new Space.Data.Space.LocationTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.LocationTags> FullSearch(Space.Data.Space.LocationTags Query, Func<Space.Data.Space.LocationTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.LocationTagsDAL dal =  new Space.Data.Space.LocationTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.LocationTags Query) {
            Space.Data.Space.LocationTagsDAL dal =  new Space.Data.Space.LocationTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.LocationTags Query) {
            Space.Data.Space.LocationTagsDAL dal =  new Space.Data.Space.LocationTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.LocationTags Query) {
            Space.Data.Space.LocationTagsDAL dal =  new Space.Data.Space.LocationTagsDAL();
            return dal.Delete(Query);
        }
    }
}
