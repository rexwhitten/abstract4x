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
    
    
    public partial class StarSectorStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarSectorStatus> Search(Space.Data.Space.StarSectorStatus Query) {
            Space.Data.Space.StarSectorStatusDAL dal =  new Space.Data.Space.StarSectorStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorStatus> Search(Space.Data.Space.StarSectorStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorStatusDAL dal =  new Space.Data.Space.StarSectorStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorStatus> FullSearch(Space.Data.Space.StarSectorStatus Query, Func<Space.Data.Space.StarSectorStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorStatusDAL dal =  new Space.Data.Space.StarSectorStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarSectorStatus Query) {
            Space.Data.Space.StarSectorStatusDAL dal =  new Space.Data.Space.StarSectorStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarSectorStatus Query) {
            Space.Data.Space.StarSectorStatusDAL dal =  new Space.Data.Space.StarSectorStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarSectorStatus Query) {
            Space.Data.Space.StarSectorStatusDAL dal =  new Space.Data.Space.StarSectorStatusDAL();
            return dal.Delete(Query);
        }
    }
}
