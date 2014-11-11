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
    
    
    public partial class QubitAttributesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitAttributes> Search(Space.Data.Space.QubitAttributes Query) {
            Space.Data.Space.QubitAttributesDAL dal =  new Space.Data.Space.QubitAttributesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitAttributes> Search(Space.Data.Space.QubitAttributes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitAttributesDAL dal =  new Space.Data.Space.QubitAttributesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitAttributes> FullSearch(Space.Data.Space.QubitAttributes Query, Func<Space.Data.Space.QubitAttributes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitAttributesDAL dal =  new Space.Data.Space.QubitAttributesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitAttributes Query) {
            Space.Data.Space.QubitAttributesDAL dal =  new Space.Data.Space.QubitAttributesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitAttributes Query) {
            Space.Data.Space.QubitAttributesDAL dal =  new Space.Data.Space.QubitAttributesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitAttributes Query) {
            Space.Data.Space.QubitAttributesDAL dal =  new Space.Data.Space.QubitAttributesDAL();
            return dal.Delete(Query);
        }
    }
}
