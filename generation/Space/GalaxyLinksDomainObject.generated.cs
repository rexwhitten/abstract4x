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
    
    
    public partial class GalaxyLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.GalaxyLinks> Search(Space.Data.Space.GalaxyLinks Query) {
            Space.Data.Space.GalaxyLinksDAL dal =  new Space.Data.Space.GalaxyLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.GalaxyLinks> Search(Space.Data.Space.GalaxyLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxyLinksDAL dal =  new Space.Data.Space.GalaxyLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.GalaxyLinks> FullSearch(Space.Data.Space.GalaxyLinks Query, Func<Space.Data.Space.GalaxyLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxyLinksDAL dal =  new Space.Data.Space.GalaxyLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.GalaxyLinks Query) {
            Space.Data.Space.GalaxyLinksDAL dal =  new Space.Data.Space.GalaxyLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.GalaxyLinks Query) {
            Space.Data.Space.GalaxyLinksDAL dal =  new Space.Data.Space.GalaxyLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.GalaxyLinks Query) {
            Space.Data.Space.GalaxyLinksDAL dal =  new Space.Data.Space.GalaxyLinksDAL();
            return dal.Delete(Query);
        }
    }
}
