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
    
    
    public partial class MoonLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.MoonLinks> Search(Space.Data.Space.MoonLinks Query) {
            Space.Data.Space.MoonLinksDAL dal =  new Space.Data.Space.MoonLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonLinks> Search(Space.Data.Space.MoonLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonLinksDAL dal =  new Space.Data.Space.MoonLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonLinks> FullSearch(Space.Data.Space.MoonLinks Query, Func<Space.Data.Space.MoonLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonLinksDAL dal =  new Space.Data.Space.MoonLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.MoonLinks Query) {
            Space.Data.Space.MoonLinksDAL dal =  new Space.Data.Space.MoonLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.MoonLinks Query) {
            Space.Data.Space.MoonLinksDAL dal =  new Space.Data.Space.MoonLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.MoonLinks Query) {
            Space.Data.Space.MoonLinksDAL dal =  new Space.Data.Space.MoonLinksDAL();
            return dal.Delete(Query);
        }
    }
}
