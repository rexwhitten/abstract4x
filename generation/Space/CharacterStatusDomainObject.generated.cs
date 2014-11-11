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
    
    
    public partial class CharacterStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.CharacterStatus> Search(Space.Data.Space.CharacterStatus Query) {
            Space.Data.Space.CharacterStatusDAL dal =  new Space.Data.Space.CharacterStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterStatus> Search(Space.Data.Space.CharacterStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterStatusDAL dal =  new Space.Data.Space.CharacterStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterStatus> FullSearch(Space.Data.Space.CharacterStatus Query, Func<Space.Data.Space.CharacterStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterStatusDAL dal =  new Space.Data.Space.CharacterStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.CharacterStatus Query) {
            Space.Data.Space.CharacterStatusDAL dal =  new Space.Data.Space.CharacterStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.CharacterStatus Query) {
            Space.Data.Space.CharacterStatusDAL dal =  new Space.Data.Space.CharacterStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.CharacterStatus Query) {
            Space.Data.Space.CharacterStatusDAL dal =  new Space.Data.Space.CharacterStatusDAL();
            return dal.Delete(Query);
        }
    }
}
