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
    
    
    public partial class LocationLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.LocationLinks> Search(Space.Data.Space.LocationLinks Query) {
            Space.Data.Space.LocationLinksDAL dal =  new Space.Data.Space.LocationLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.LocationLinks> Search(Space.Data.Space.LocationLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.LocationLinksDAL dal =  new Space.Data.Space.LocationLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.LocationLinks> FullSearch(Space.Data.Space.LocationLinks Query, Func<Space.Data.Space.LocationLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.LocationLinksDAL dal =  new Space.Data.Space.LocationLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.LocationLinks Query) {
            Space.Data.Space.LocationLinksDAL dal =  new Space.Data.Space.LocationLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.LocationLinks Query) {
            Space.Data.Space.LocationLinksDAL dal =  new Space.Data.Space.LocationLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.LocationLinks Query) {
            Space.Data.Space.LocationLinksDAL dal =  new Space.Data.Space.LocationLinksDAL();
            return dal.Delete(Query);
        }
    }
}
