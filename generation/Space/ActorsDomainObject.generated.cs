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
    
    
    public partial class ActorsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.Actors> Search(Space.Data.Space.Actors Query) {
            Space.Data.Space.ActorsDAL dal =  new Space.Data.Space.ActorsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.Actors> Search(Space.Data.Space.Actors Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.ActorsDAL dal =  new Space.Data.Space.ActorsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.Actors> FullSearch(Space.Data.Space.Actors Query, Func<Space.Data.Space.Actors,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.ActorsDAL dal =  new Space.Data.Space.ActorsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.Actors Query) {
            Space.Data.Space.ActorsDAL dal =  new Space.Data.Space.ActorsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.Actors Query) {
            Space.Data.Space.ActorsDAL dal =  new Space.Data.Space.ActorsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.Actors Query) {
            Space.Data.Space.ActorsDAL dal =  new Space.Data.Space.ActorsDAL();
            return dal.Delete(Query);
        }
    }
}
