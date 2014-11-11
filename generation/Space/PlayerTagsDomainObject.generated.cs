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
    
    
    public partial class PlayerTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlayerTags> Search(Space.Data.Space.PlayerTags Query) {
            Space.Data.Space.PlayerTagsDAL dal =  new Space.Data.Space.PlayerTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerTags> Search(Space.Data.Space.PlayerTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerTagsDAL dal =  new Space.Data.Space.PlayerTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerTags> FullSearch(Space.Data.Space.PlayerTags Query, Func<Space.Data.Space.PlayerTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerTagsDAL dal =  new Space.Data.Space.PlayerTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlayerTags Query) {
            Space.Data.Space.PlayerTagsDAL dal =  new Space.Data.Space.PlayerTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlayerTags Query) {
            Space.Data.Space.PlayerTagsDAL dal =  new Space.Data.Space.PlayerTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlayerTags Query) {
            Space.Data.Space.PlayerTagsDAL dal =  new Space.Data.Space.PlayerTagsDAL();
            return dal.Delete(Query);
        }
    }
}
