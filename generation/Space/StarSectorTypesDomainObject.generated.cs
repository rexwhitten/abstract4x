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
    
    
    public partial class StarSectorTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarSectorTypes> Search(Space.Data.Space.StarSectorTypes Query) {
            Space.Data.Space.StarSectorTypesDAL dal =  new Space.Data.Space.StarSectorTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorTypes> Search(Space.Data.Space.StarSectorTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorTypesDAL dal =  new Space.Data.Space.StarSectorTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorTypes> FullSearch(Space.Data.Space.StarSectorTypes Query, Func<Space.Data.Space.StarSectorTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorTypesDAL dal =  new Space.Data.Space.StarSectorTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarSectorTypes Query) {
            Space.Data.Space.StarSectorTypesDAL dal =  new Space.Data.Space.StarSectorTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarSectorTypes Query) {
            Space.Data.Space.StarSectorTypesDAL dal =  new Space.Data.Space.StarSectorTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarSectorTypes Query) {
            Space.Data.Space.StarSectorTypesDAL dal =  new Space.Data.Space.StarSectorTypesDAL();
            return dal.Delete(Query);
        }
    }
}
