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
    
    
    public partial class AsteroidFiledStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledStatus> Search(Space.Data.Space.AsteroidFiledStatus Query) {
            Space.Data.Space.AsteroidFiledStatusDAL dal =  new Space.Data.Space.AsteroidFiledStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledStatus> Search(Space.Data.Space.AsteroidFiledStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledStatusDAL dal =  new Space.Data.Space.AsteroidFiledStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledStatus> FullSearch(Space.Data.Space.AsteroidFiledStatus Query, Func<Space.Data.Space.AsteroidFiledStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledStatusDAL dal =  new Space.Data.Space.AsteroidFiledStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.AsteroidFiledStatus Query) {
            Space.Data.Space.AsteroidFiledStatusDAL dal =  new Space.Data.Space.AsteroidFiledStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.AsteroidFiledStatus Query) {
            Space.Data.Space.AsteroidFiledStatusDAL dal =  new Space.Data.Space.AsteroidFiledStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.AsteroidFiledStatus Query) {
            Space.Data.Space.AsteroidFiledStatusDAL dal =  new Space.Data.Space.AsteroidFiledStatusDAL();
            return dal.Delete(Query);
        }
    }
}
