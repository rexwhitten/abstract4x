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
    
    
    public partial class StarLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarLinks> Search(Space.Data.Space.StarLinks Query) {
            Space.Data.Space.StarLinksDAL dal =  new Space.Data.Space.StarLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarLinks> Search(Space.Data.Space.StarLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarLinksDAL dal =  new Space.Data.Space.StarLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarLinks> FullSearch(Space.Data.Space.StarLinks Query, Func<Space.Data.Space.StarLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarLinksDAL dal =  new Space.Data.Space.StarLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarLinks Query) {
            Space.Data.Space.StarLinksDAL dal =  new Space.Data.Space.StarLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarLinks Query) {
            Space.Data.Space.StarLinksDAL dal =  new Space.Data.Space.StarLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarLinks Query) {
            Space.Data.Space.StarLinksDAL dal =  new Space.Data.Space.StarLinksDAL();
            return dal.Delete(Query);
        }
    }
}
