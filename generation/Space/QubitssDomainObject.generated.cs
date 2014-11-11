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
    
    
    public partial class QubitssDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.Qubitss> Search(Space.Data.Space.Qubitss Query) {
            Space.Data.Space.QubitssDAL dal =  new Space.Data.Space.QubitssDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.Qubitss> Search(Space.Data.Space.Qubitss Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitssDAL dal =  new Space.Data.Space.QubitssDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.Qubitss> FullSearch(Space.Data.Space.Qubitss Query, Func<Space.Data.Space.Qubitss,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitssDAL dal =  new Space.Data.Space.QubitssDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.Qubitss Query) {
            Space.Data.Space.QubitssDAL dal =  new Space.Data.Space.QubitssDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.Qubitss Query) {
            Space.Data.Space.QubitssDAL dal =  new Space.Data.Space.QubitssDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.Qubitss Query) {
            Space.Data.Space.QubitssDAL dal =  new Space.Data.Space.QubitssDAL();
            return dal.Delete(Query);
        }
    }
}
