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
    
    
    public partial class PlayerLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlayerLinks> Search(Space.Data.Space.PlayerLinks Query) {
            Space.Data.Space.PlayerLinksDAL dal =  new Space.Data.Space.PlayerLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerLinks> Search(Space.Data.Space.PlayerLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerLinksDAL dal =  new Space.Data.Space.PlayerLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerLinks> FullSearch(Space.Data.Space.PlayerLinks Query, Func<Space.Data.Space.PlayerLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerLinksDAL dal =  new Space.Data.Space.PlayerLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlayerLinks Query) {
            Space.Data.Space.PlayerLinksDAL dal =  new Space.Data.Space.PlayerLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlayerLinks Query) {
            Space.Data.Space.PlayerLinksDAL dal =  new Space.Data.Space.PlayerLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlayerLinks Query) {
            Space.Data.Space.PlayerLinksDAL dal =  new Space.Data.Space.PlayerLinksDAL();
            return dal.Delete(Query);
        }
    }
}
