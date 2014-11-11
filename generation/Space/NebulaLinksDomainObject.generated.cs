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
    
    
    public partial class NebulaLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.NebulaLinks> Search(Space.Data.Space.NebulaLinks Query) {
            Space.Data.Space.NebulaLinksDAL dal =  new Space.Data.Space.NebulaLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.NebulaLinks> Search(Space.Data.Space.NebulaLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.NebulaLinksDAL dal =  new Space.Data.Space.NebulaLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.NebulaLinks> FullSearch(Space.Data.Space.NebulaLinks Query, Func<Space.Data.Space.NebulaLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.NebulaLinksDAL dal =  new Space.Data.Space.NebulaLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.NebulaLinks Query) {
            Space.Data.Space.NebulaLinksDAL dal =  new Space.Data.Space.NebulaLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.NebulaLinks Query) {
            Space.Data.Space.NebulaLinksDAL dal =  new Space.Data.Space.NebulaLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.NebulaLinks Query) {
            Space.Data.Space.NebulaLinksDAL dal =  new Space.Data.Space.NebulaLinksDAL();
            return dal.Delete(Query);
        }
    }
}
