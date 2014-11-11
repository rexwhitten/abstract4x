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
    
    
    public partial class MoonStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.MoonStatus> Search(Space.Data.Space.MoonStatus Query) {
            Space.Data.Space.MoonStatusDAL dal =  new Space.Data.Space.MoonStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonStatus> Search(Space.Data.Space.MoonStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonStatusDAL dal =  new Space.Data.Space.MoonStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonStatus> FullSearch(Space.Data.Space.MoonStatus Query, Func<Space.Data.Space.MoonStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonStatusDAL dal =  new Space.Data.Space.MoonStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.MoonStatus Query) {
            Space.Data.Space.MoonStatusDAL dal =  new Space.Data.Space.MoonStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.MoonStatus Query) {
            Space.Data.Space.MoonStatusDAL dal =  new Space.Data.Space.MoonStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.MoonStatus Query) {
            Space.Data.Space.MoonStatusDAL dal =  new Space.Data.Space.MoonStatusDAL();
            return dal.Delete(Query);
        }
    }
}
