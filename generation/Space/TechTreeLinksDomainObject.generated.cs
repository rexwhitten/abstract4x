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
    
    
    public partial class TechTreeLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.TechTreeLinks> Search(Space.Data.Space.TechTreeLinks Query) {
            Space.Data.Space.TechTreeLinksDAL dal =  new Space.Data.Space.TechTreeLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeLinks> Search(Space.Data.Space.TechTreeLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeLinksDAL dal =  new Space.Data.Space.TechTreeLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeLinks> FullSearch(Space.Data.Space.TechTreeLinks Query, Func<Space.Data.Space.TechTreeLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeLinksDAL dal =  new Space.Data.Space.TechTreeLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.TechTreeLinks Query) {
            Space.Data.Space.TechTreeLinksDAL dal =  new Space.Data.Space.TechTreeLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.TechTreeLinks Query) {
            Space.Data.Space.TechTreeLinksDAL dal =  new Space.Data.Space.TechTreeLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.TechTreeLinks Query) {
            Space.Data.Space.TechTreeLinksDAL dal =  new Space.Data.Space.TechTreeLinksDAL();
            return dal.Delete(Query);
        }
    }
}
