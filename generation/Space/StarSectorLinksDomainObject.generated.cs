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
    
    
    public partial class StarSectorLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarSectorLinks> Search(Space.Data.Space.StarSectorLinks Query) {
            Space.Data.Space.StarSectorLinksDAL dal =  new Space.Data.Space.StarSectorLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorLinks> Search(Space.Data.Space.StarSectorLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorLinksDAL dal =  new Space.Data.Space.StarSectorLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorLinks> FullSearch(Space.Data.Space.StarSectorLinks Query, Func<Space.Data.Space.StarSectorLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorLinksDAL dal =  new Space.Data.Space.StarSectorLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarSectorLinks Query) {
            Space.Data.Space.StarSectorLinksDAL dal =  new Space.Data.Space.StarSectorLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarSectorLinks Query) {
            Space.Data.Space.StarSectorLinksDAL dal =  new Space.Data.Space.StarSectorLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarSectorLinks Query) {
            Space.Data.Space.StarSectorLinksDAL dal =  new Space.Data.Space.StarSectorLinksDAL();
            return dal.Delete(Query);
        }
    }
}
