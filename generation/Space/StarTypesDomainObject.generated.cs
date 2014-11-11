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
    
    
    public partial class StarTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarTypes> Search(Space.Data.Space.StarTypes Query) {
            Space.Data.Space.StarTypesDAL dal =  new Space.Data.Space.StarTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarTypes> Search(Space.Data.Space.StarTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarTypesDAL dal =  new Space.Data.Space.StarTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarTypes> FullSearch(Space.Data.Space.StarTypes Query, Func<Space.Data.Space.StarTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarTypesDAL dal =  new Space.Data.Space.StarTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarTypes Query) {
            Space.Data.Space.StarTypesDAL dal =  new Space.Data.Space.StarTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarTypes Query) {
            Space.Data.Space.StarTypesDAL dal =  new Space.Data.Space.StarTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarTypes Query) {
            Space.Data.Space.StarTypesDAL dal =  new Space.Data.Space.StarTypesDAL();
            return dal.Delete(Query);
        }
    }
}
