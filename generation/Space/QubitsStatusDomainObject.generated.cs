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
    
    
    public partial class QubitsStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitsStatus> Search(Space.Data.Space.QubitsStatus Query) {
            Space.Data.Space.QubitsStatusDAL dal =  new Space.Data.Space.QubitsStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitsStatus> Search(Space.Data.Space.QubitsStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsStatusDAL dal =  new Space.Data.Space.QubitsStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitsStatus> FullSearch(Space.Data.Space.QubitsStatus Query, Func<Space.Data.Space.QubitsStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsStatusDAL dal =  new Space.Data.Space.QubitsStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitsStatus Query) {
            Space.Data.Space.QubitsStatusDAL dal =  new Space.Data.Space.QubitsStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitsStatus Query) {
            Space.Data.Space.QubitsStatusDAL dal =  new Space.Data.Space.QubitsStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitsStatus Query) {
            Space.Data.Space.QubitsStatusDAL dal =  new Space.Data.Space.QubitsStatusDAL();
            return dal.Delete(Query);
        }
    }
}
