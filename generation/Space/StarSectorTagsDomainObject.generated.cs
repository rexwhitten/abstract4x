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
    
    
    public partial class StarSectorTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarSectorTags> Search(Space.Data.Space.StarSectorTags Query) {
            Space.Data.Space.StarSectorTagsDAL dal =  new Space.Data.Space.StarSectorTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorTags> Search(Space.Data.Space.StarSectorTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorTagsDAL dal =  new Space.Data.Space.StarSectorTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorTags> FullSearch(Space.Data.Space.StarSectorTags Query, Func<Space.Data.Space.StarSectorTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorTagsDAL dal =  new Space.Data.Space.StarSectorTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarSectorTags Query) {
            Space.Data.Space.StarSectorTagsDAL dal =  new Space.Data.Space.StarSectorTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarSectorTags Query) {
            Space.Data.Space.StarSectorTagsDAL dal =  new Space.Data.Space.StarSectorTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarSectorTags Query) {
            Space.Data.Space.StarSectorTagsDAL dal =  new Space.Data.Space.StarSectorTagsDAL();
            return dal.Delete(Query);
        }
    }
}
