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
    
    
    public partial class PlayerAttributesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlayerAttributes> Search(Space.Data.Space.PlayerAttributes Query) {
            Space.Data.Space.PlayerAttributesDAL dal =  new Space.Data.Space.PlayerAttributesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerAttributes> Search(Space.Data.Space.PlayerAttributes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerAttributesDAL dal =  new Space.Data.Space.PlayerAttributesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerAttributes> FullSearch(Space.Data.Space.PlayerAttributes Query, Func<Space.Data.Space.PlayerAttributes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerAttributesDAL dal =  new Space.Data.Space.PlayerAttributesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlayerAttributes Query) {
            Space.Data.Space.PlayerAttributesDAL dal =  new Space.Data.Space.PlayerAttributesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlayerAttributes Query) {
            Space.Data.Space.PlayerAttributesDAL dal =  new Space.Data.Space.PlayerAttributesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlayerAttributes Query) {
            Space.Data.Space.PlayerAttributesDAL dal =  new Space.Data.Space.PlayerAttributesDAL();
            return dal.Delete(Query);
        }
    }
}
