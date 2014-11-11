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
    
    
    public partial class MoonTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.MoonTags> Search(Space.Data.Space.MoonTags Query) {
            Space.Data.Space.MoonTagsDAL dal =  new Space.Data.Space.MoonTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonTags> Search(Space.Data.Space.MoonTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonTagsDAL dal =  new Space.Data.Space.MoonTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonTags> FullSearch(Space.Data.Space.MoonTags Query, Func<Space.Data.Space.MoonTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonTagsDAL dal =  new Space.Data.Space.MoonTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.MoonTags Query) {
            Space.Data.Space.MoonTagsDAL dal =  new Space.Data.Space.MoonTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.MoonTags Query) {
            Space.Data.Space.MoonTagsDAL dal =  new Space.Data.Space.MoonTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.MoonTags Query) {
            Space.Data.Space.MoonTagsDAL dal =  new Space.Data.Space.MoonTagsDAL();
            return dal.Delete(Query);
        }
    }
}
