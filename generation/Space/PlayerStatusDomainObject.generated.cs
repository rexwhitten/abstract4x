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
    
    
    public partial class PlayerStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlayerStatus> Search(Space.Data.Space.PlayerStatus Query) {
            Space.Data.Space.PlayerStatusDAL dal =  new Space.Data.Space.PlayerStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerStatus> Search(Space.Data.Space.PlayerStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerStatusDAL dal =  new Space.Data.Space.PlayerStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerStatus> FullSearch(Space.Data.Space.PlayerStatus Query, Func<Space.Data.Space.PlayerStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerStatusDAL dal =  new Space.Data.Space.PlayerStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlayerStatus Query) {
            Space.Data.Space.PlayerStatusDAL dal =  new Space.Data.Space.PlayerStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlayerStatus Query) {
            Space.Data.Space.PlayerStatusDAL dal =  new Space.Data.Space.PlayerStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlayerStatus Query) {
            Space.Data.Space.PlayerStatusDAL dal =  new Space.Data.Space.PlayerStatusDAL();
            return dal.Delete(Query);
        }
    }
}
