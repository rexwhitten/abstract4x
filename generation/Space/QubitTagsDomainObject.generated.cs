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
    
    
    public partial class QubitTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitTags> Search(Space.Data.Space.QubitTags Query) {
            Space.Data.Space.QubitTagsDAL dal =  new Space.Data.Space.QubitTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitTags> Search(Space.Data.Space.QubitTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitTagsDAL dal =  new Space.Data.Space.QubitTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitTags> FullSearch(Space.Data.Space.QubitTags Query, Func<Space.Data.Space.QubitTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitTagsDAL dal =  new Space.Data.Space.QubitTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitTags Query) {
            Space.Data.Space.QubitTagsDAL dal =  new Space.Data.Space.QubitTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitTags Query) {
            Space.Data.Space.QubitTagsDAL dal =  new Space.Data.Space.QubitTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitTags Query) {
            Space.Data.Space.QubitTagsDAL dal =  new Space.Data.Space.QubitTagsDAL();
            return dal.Delete(Query);
        }
    }
}
