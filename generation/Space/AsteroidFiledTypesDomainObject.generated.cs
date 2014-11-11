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
    
    
    public partial class AsteroidFiledTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledTypes> Search(Space.Data.Space.AsteroidFiledTypes Query) {
            Space.Data.Space.AsteroidFiledTypesDAL dal =  new Space.Data.Space.AsteroidFiledTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledTypes> Search(Space.Data.Space.AsteroidFiledTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledTypesDAL dal =  new Space.Data.Space.AsteroidFiledTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledTypes> FullSearch(Space.Data.Space.AsteroidFiledTypes Query, Func<Space.Data.Space.AsteroidFiledTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledTypesDAL dal =  new Space.Data.Space.AsteroidFiledTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.AsteroidFiledTypes Query) {
            Space.Data.Space.AsteroidFiledTypesDAL dal =  new Space.Data.Space.AsteroidFiledTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.AsteroidFiledTypes Query) {
            Space.Data.Space.AsteroidFiledTypesDAL dal =  new Space.Data.Space.AsteroidFiledTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.AsteroidFiledTypes Query) {
            Space.Data.Space.AsteroidFiledTypesDAL dal =  new Space.Data.Space.AsteroidFiledTypesDAL();
            return dal.Delete(Query);
        }
    }
}
