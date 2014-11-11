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
    
    
    public partial class QubitTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitTypes> Search(Space.Data.Space.QubitTypes Query) {
            Space.Data.Space.QubitTypesDAL dal =  new Space.Data.Space.QubitTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitTypes> Search(Space.Data.Space.QubitTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitTypesDAL dal =  new Space.Data.Space.QubitTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitTypes> FullSearch(Space.Data.Space.QubitTypes Query, Func<Space.Data.Space.QubitTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitTypesDAL dal =  new Space.Data.Space.QubitTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitTypes Query) {
            Space.Data.Space.QubitTypesDAL dal =  new Space.Data.Space.QubitTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitTypes Query) {
            Space.Data.Space.QubitTypesDAL dal =  new Space.Data.Space.QubitTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitTypes Query) {
            Space.Data.Space.QubitTypesDAL dal =  new Space.Data.Space.QubitTypesDAL();
            return dal.Delete(Query);
        }
    }
}
