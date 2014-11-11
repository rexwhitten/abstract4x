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
    
    
    public partial class StarsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.Stars> Search(Space.Data.Space.Stars Query) {
            Space.Data.Space.StarsDAL dal =  new Space.Data.Space.StarsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.Stars> Search(Space.Data.Space.Stars Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarsDAL dal =  new Space.Data.Space.StarsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.Stars> FullSearch(Space.Data.Space.Stars Query, Func<Space.Data.Space.Stars,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarsDAL dal =  new Space.Data.Space.StarsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.Stars Query) {
            Space.Data.Space.StarsDAL dal =  new Space.Data.Space.StarsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.Stars Query) {
            Space.Data.Space.StarsDAL dal =  new Space.Data.Space.StarsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.Stars Query) {
            Space.Data.Space.StarsDAL dal =  new Space.Data.Space.StarsDAL();
            return dal.Delete(Query);
        }
    }
}
