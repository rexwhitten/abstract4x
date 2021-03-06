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
    
    
    public partial class TechTreeTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.TechTreeTags> Search(Space.Data.Space.TechTreeTags Query) {
            Space.Data.Space.TechTreeTagsDAL dal =  new Space.Data.Space.TechTreeTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeTags> Search(Space.Data.Space.TechTreeTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeTagsDAL dal =  new Space.Data.Space.TechTreeTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeTags> FullSearch(Space.Data.Space.TechTreeTags Query, Func<Space.Data.Space.TechTreeTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeTagsDAL dal =  new Space.Data.Space.TechTreeTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.TechTreeTags Query) {
            Space.Data.Space.TechTreeTagsDAL dal =  new Space.Data.Space.TechTreeTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.TechTreeTags Query) {
            Space.Data.Space.TechTreeTagsDAL dal =  new Space.Data.Space.TechTreeTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.TechTreeTags Query) {
            Space.Data.Space.TechTreeTagsDAL dal =  new Space.Data.Space.TechTreeTagsDAL();
            return dal.Delete(Query);
        }
    }
}
