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
    
    
    public partial class GalaxyStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.GalaxyStatus> Search(Space.Data.Space.GalaxyStatus Query) {
            Space.Data.Space.GalaxyStatusDAL dal =  new Space.Data.Space.GalaxyStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.GalaxyStatus> Search(Space.Data.Space.GalaxyStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxyStatusDAL dal =  new Space.Data.Space.GalaxyStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.GalaxyStatus> FullSearch(Space.Data.Space.GalaxyStatus Query, Func<Space.Data.Space.GalaxyStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxyStatusDAL dal =  new Space.Data.Space.GalaxyStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.GalaxyStatus Query) {
            Space.Data.Space.GalaxyStatusDAL dal =  new Space.Data.Space.GalaxyStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.GalaxyStatus Query) {
            Space.Data.Space.GalaxyStatusDAL dal =  new Space.Data.Space.GalaxyStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.GalaxyStatus Query) {
            Space.Data.Space.GalaxyStatusDAL dal =  new Space.Data.Space.GalaxyStatusDAL();
            return dal.Delete(Query);
        }
    }
}
