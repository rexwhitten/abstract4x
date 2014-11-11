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
    
    
    public partial class QubitStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitStatus> Search(Space.Data.Space.QubitStatus Query) {
            Space.Data.Space.QubitStatusDAL dal =  new Space.Data.Space.QubitStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitStatus> Search(Space.Data.Space.QubitStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitStatusDAL dal =  new Space.Data.Space.QubitStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitStatus> FullSearch(Space.Data.Space.QubitStatus Query, Func<Space.Data.Space.QubitStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitStatusDAL dal =  new Space.Data.Space.QubitStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitStatus Query) {
            Space.Data.Space.QubitStatusDAL dal =  new Space.Data.Space.QubitStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitStatus Query) {
            Space.Data.Space.QubitStatusDAL dal =  new Space.Data.Space.QubitStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitStatus Query) {
            Space.Data.Space.QubitStatusDAL dal =  new Space.Data.Space.QubitStatusDAL();
            return dal.Delete(Query);
        }
    }
}
