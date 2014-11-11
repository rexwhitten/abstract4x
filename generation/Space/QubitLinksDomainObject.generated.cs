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
    
    
    public partial class QubitLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitLinks> Search(Space.Data.Space.QubitLinks Query) {
            Space.Data.Space.QubitLinksDAL dal =  new Space.Data.Space.QubitLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitLinks> Search(Space.Data.Space.QubitLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitLinksDAL dal =  new Space.Data.Space.QubitLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitLinks> FullSearch(Space.Data.Space.QubitLinks Query, Func<Space.Data.Space.QubitLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitLinksDAL dal =  new Space.Data.Space.QubitLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitLinks Query) {
            Space.Data.Space.QubitLinksDAL dal =  new Space.Data.Space.QubitLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitLinks Query) {
            Space.Data.Space.QubitLinksDAL dal =  new Space.Data.Space.QubitLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitLinks Query) {
            Space.Data.Space.QubitLinksDAL dal =  new Space.Data.Space.QubitLinksDAL();
            return dal.Delete(Query);
        }
    }
}
