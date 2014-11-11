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
    
    
    public partial class AsteroidFiledsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFileds> Search(Space.Data.Space.AsteroidFileds Query) {
            Space.Data.Space.AsteroidFiledsDAL dal =  new Space.Data.Space.AsteroidFiledsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFileds> Search(Space.Data.Space.AsteroidFileds Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledsDAL dal =  new Space.Data.Space.AsteroidFiledsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFileds> FullSearch(Space.Data.Space.AsteroidFileds Query, Func<Space.Data.Space.AsteroidFileds,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledsDAL dal =  new Space.Data.Space.AsteroidFiledsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.AsteroidFileds Query) {
            Space.Data.Space.AsteroidFiledsDAL dal =  new Space.Data.Space.AsteroidFiledsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.AsteroidFileds Query) {
            Space.Data.Space.AsteroidFiledsDAL dal =  new Space.Data.Space.AsteroidFiledsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.AsteroidFileds Query) {
            Space.Data.Space.AsteroidFiledsDAL dal =  new Space.Data.Space.AsteroidFiledsDAL();
            return dal.Delete(Query);
        }
    }
}
