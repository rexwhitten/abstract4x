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
    
    
    public partial class AsteroidFiledLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledLinks> Search(Space.Data.Space.AsteroidFiledLinks Query) {
            Space.Data.Space.AsteroidFiledLinksDAL dal =  new Space.Data.Space.AsteroidFiledLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledLinks> Search(Space.Data.Space.AsteroidFiledLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledLinksDAL dal =  new Space.Data.Space.AsteroidFiledLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledLinks> FullSearch(Space.Data.Space.AsteroidFiledLinks Query, Func<Space.Data.Space.AsteroidFiledLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledLinksDAL dal =  new Space.Data.Space.AsteroidFiledLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.AsteroidFiledLinks Query) {
            Space.Data.Space.AsteroidFiledLinksDAL dal =  new Space.Data.Space.AsteroidFiledLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.AsteroidFiledLinks Query) {
            Space.Data.Space.AsteroidFiledLinksDAL dal =  new Space.Data.Space.AsteroidFiledLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.AsteroidFiledLinks Query) {
            Space.Data.Space.AsteroidFiledLinksDAL dal =  new Space.Data.Space.AsteroidFiledLinksDAL();
            return dal.Delete(Query);
        }
    }
}
